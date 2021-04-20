using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Buffet.Models.Acesso;
using Buffet.Models.Buffet.Cliente;
using Buffet.RequestModels;
using Buffet.ViewModels.Acesso;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers
{
    public class AcessoController : Controller
    {
        private readonly AcessoService _acessoService;

        public AcessoController(AcessoService acessoService)
        {
            _acessoService = acessoService;
        }

        public IActionResult Login()
        {
            var view = new GenericViewModel(TempData["msg_erro"]==null?"":(string) TempData["msg_erro"]);
            
            return View(view);
        }

        public IActionResult RecuperarConta()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            var view = new GenericViewModel(TempData["msg_erro"]==null?"":(string) TempData["msg_erro"]);
            
            return View(view);
        }

        [HttpPost]
        public async Task<RedirectResult> RealizaCadastro(CadastroRequestModel request)
        {

            TempData["msg_erro"] = "";
            
            var nome = request.Nome;
            if (nome == null)
            {
                TempData["msg_erro"] += "Por favor informe o nome! \n";
            }
            
            var email = request.Email;
            if (email == null)
            {
                TempData["msg_erro"] += "Por favor informe o email! \n";
            }
            var senha = request.Senha;
            if (senha == null)
            {
                TempData["msg_erro"] += "Por favor informe a senha! \n";
            }
            var senha_rep = request.Senha_Rep;
            if (senha != senha_rep)
            {
                TempData["msg_erro"] += "As senhas não conferem, por favor digite novamente! \n";
            }

            if ((string) TempData["msg_erro"] == "")
            {
                try
                {
                    await _acessoService.RegistrarUsuario(nome, email, senha);
                    TempData["msg_erro"] = "Usuário registrado com sucesso!";
                    return Redirect("/Acesso/Login");
                }
                catch (Exception ex)
                {
                    TempData["msg_erro"] = "Algum erro ocorreu ao registrar o usuário!";
                    Console.WriteLine(ex.Message);
                }
            }

            return Redirect("/Acesso/Cadastrar");
        }

        [HttpPost]
        public async Task<RedirectResult> RealizaLogin(LoginRequestModel request)
        {
            TempData["msg_erro"] = "";
            
            var email = request.Email;
            if (email == null)
            {
                TempData["msg_erro"] += "Por favor informe o email! \n";
            }
            var senha = request.Senha;
            if (senha == null)
            {
                TempData["msg_erro"] += "Por favor informe a senha! \n";
            }
            
            if ((string) TempData["msg_erro"] == "")
            {
                try
                {
                    await _acessoService.LogarUsuario(email, senha);
                    TempData["msg_erro"] = "Seja bem vindo!";
                    return Redirect("/PainelDoUsuario/PainelDoUsuario");
                }
                catch (Exception ex)
                {
                    TempData["msg_erro"] += ex.Message;
                }
            }

            return Redirect("/Acesso/Login");
        }
        
    }
}