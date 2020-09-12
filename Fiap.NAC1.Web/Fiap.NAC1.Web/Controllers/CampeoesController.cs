using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.NAC1.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.NAC1.Web.Controllers
{
    public class CampeoesController : Controller
    {
        private static List<Campeoes> _banco = new List<Campeoes>();

        public IActionResult Index(string? nome)
        {
            if (!String.IsNullOrEmpty(nome))
            {
                var lista = new List<Campeoes>();
                foreach(var c in _banco)
                {
                    if(c.Preco <= int.Parse(nome))
                    {
                        lista.Add(c);
                    }
                }
                
                return View(lista);
            }
            else
            {
                return View(_banco);

            }

        }

        [HttpPost]
        public IActionResult Cadastrar(Campeoes campeoes)
        {
            campeoes.Codigo = _banco.Count + 1;
            _banco.Add(campeoes);
            TempData["msg"] = "Campeao cadastrado";
            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var campeoes = _banco.Find(c => c.Codigo == id);
            return View(campeoes);
        }

        [HttpPost]
        public IActionResult Editar(Campeoes campeoes)
        {
            var camp = _banco.Find(c=>c.Codigo == campeoes.Codigo);
            _banco.Remove(camp);
            _banco.Add(campeoes);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(int id)
        {
            _banco.RemoveAt(_banco.FindIndex(c => c.Codigo == id));
            return RedirectToAction("Index");
        }
    }
}
