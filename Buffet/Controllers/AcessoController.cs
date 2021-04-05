using System;
using System.Collections.Generic;
using System.Diagnostics;
using Buffet.Models.Buffet.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers
{
    public class AcessoController : Controller
    {
        public AcessoController()
        {
            
        }

        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult RecuperarConta()
        {
            return View();
        }
        
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}