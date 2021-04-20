using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Buffet.Models.Acesso
{
    public class AcessoService
    {
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;

        public AcessoService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task RegistrarUsuario(string nome, string email, string senha)
        {
            var user = new Usuario()
            {
                Email = email,
                UserName = email,
                Nome = nome
            };

            var rs = await userManager.CreateAsync(user, senha);

            if (!rs.Succeeded)
            {
                string error = "";
                foreach (var identityError in rs.Errors)
                {
                    error += identityError.Description + "\n";
                }

                throw new Exception(error);
            }
        }
        
        public async Task LogarUsuario(string email, string senha)
        {

            var rs = await signInManager.PasswordSignInAsync(email, senha, false, false);

            if (!rs.Succeeded)
            {
                throw new Exception("Não foi possível realizar seu login, verifique usuário e senha");
            }
        }
        
    }
}