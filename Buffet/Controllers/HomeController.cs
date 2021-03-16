﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Buffet.Models;
using Buffet.Models.Buffet.Cliente;
using Buffet.ViewModels.Home;

namespace Buffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // 1º Forma de enviar dados para a view
            ViewBag.InformacaoQualquer = "Informação Qualquer";
            
            // 2º Forma de enviar dados para a view
            ViewData["informacao"] = "Outra informação";
            
            // 3º Forma de enviar dados para a view
            var viewmodel = new IndexViewModel();
            viewmodel.InformacaoQualquer = "Informação pela View Model";
            viewmodel.Titulo = "Título qualquer";
            
            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Clientes()
        {
            // Trazer lista de entidade clientes do serviço de clientes (model)
            var clienteService = new ClienteService();
            var listaDeClientes = clienteService.ObterClientes();

            // Criar e popular a viewmodel
            var viewModel = new ClientesViewModel();
            foreach (ClienteEntity clienteEntity in listaDeClientes) {
                viewModel.Clientes.Add(new Cliente
                {
                    Nome = clienteEntity.Nome,
                    DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString(),
                    Idade = clienteEntity.Idade
                });
            }
            
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}