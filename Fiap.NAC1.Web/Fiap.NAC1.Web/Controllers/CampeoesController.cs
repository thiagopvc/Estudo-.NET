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

        public IActionResult Index(string preco)
        {
            if (!String.IsNullOrEmpty(preco))
            {
                var camp = new List<Campeoes>();
                foreach(var campeao in _banco)
                {
                    if(campeao.Preco <= float.Parse(preco))
                    {
                        camp.Add(campeao);
                    }
                }
                return View(camp);
            }
            return View(_banco); 
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
            var camp = _banco.Find(c => c.Codigo == id);
            _banco.Remove(camp);
            TempData["msg"] = "Deletado";
            return View();
        }
    }
}
