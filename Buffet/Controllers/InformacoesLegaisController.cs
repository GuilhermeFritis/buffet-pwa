﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AromaBuffet.Controllers
{
    public class InformacoesLegaisController : Controller
    {
        public InformacoesLegaisController(){
        }

        public IActionResult TermosDeUso()
        {   
            return View();
        }
        
        public IActionResult PoliticaDePrivacidade()
        {   
            return View();
        }
    }
}