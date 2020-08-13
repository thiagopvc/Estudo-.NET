using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula02.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula02.Web.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abre a pagina com o formulario
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Adicionado apos o submit do formulario
        public IActionResult Cadastrar(Cliente cliente)
        {
            //return Content(cliente.Nome + " " + cliente.Sobrenome + " " + cliente.Idade); //retorna um texto
            //Envia uma informacao para a view
            ViewData["nome"] = cliente.Nome + " " + cliente.Sobrenome;
            ViewBag.idade = cliente.Idade;
            ViewBag.customer = cliente;

            //Mantem a informacao apos um redirect
            TempData["msg"] = "Cliente cadastrado";
            
            //Redirect
            return RedirectToAction("Cadastrar");
        }
    }
}
