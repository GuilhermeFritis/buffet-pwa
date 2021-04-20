using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Buffet.Models;
using Buffet.ViewModels.Acesso;
using Buffet.ViewModels.Home;

namespace Buffet.Controllers.Admin
{
    public class PainelDoUsuarioController : Controller
    {
        public PainelDoUsuarioController()
        {
        }

        public IActionResult PainelDoUsuario()
        {
            var view = new GenericViewModel(TempData["msg_erro"]==null?"":(string) TempData["msg_erro"]);
            
            return View(view);
        }
    }
}