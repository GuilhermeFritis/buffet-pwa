using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AromaBuffet.Controllers
{
    public class AjudaController : Controller
    {
        public AjudaController(){
        }

        public IActionResult Ajuda()
        {   
            return View();
        }
    }
}