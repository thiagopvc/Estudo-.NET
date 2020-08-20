using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class PacienteController : Controller
    {
        //Simular o banco de dados
        private static List<Paciente> _banco = new List<Paciente>();

        //Listar todos os pacientes
        public IActionResult Index()
        {
            return View(_banco); //envia a lista de pacientes para a view
        }

        [HttpPost]
        public IActionResult Editar(Paciente paciente)
        {
            var pac = _banco.Find(p => p.Codigo == paciente.Codigo);
            _banco.Remove(pac);
            _banco.Add(paciente);
            return RedirectToAction("Index");
        }

        //Abre a pagina de edicao com os dados do paciente
        [HttpGet]
        public IActionResult Editar(int id)
        {
            //pesquisar o paciente do codigo (id) informado
            var paciente = _banco.Find(p=>p.Codigo == id);
            return View(paciente); //envia o paciente para a view
        }

        //Cadastrar um paciente na lista
        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            paciente.Codigo = _banco.Count + 1; //Gerar um codigo para o paciente
            _banco.Add(paciente);
            TempData["msg"] = "Paciente Cadastrado";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
