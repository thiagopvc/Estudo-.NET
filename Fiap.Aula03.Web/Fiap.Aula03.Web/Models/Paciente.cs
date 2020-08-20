using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Models
{
    public class Paciente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Entrada")]
        public DateTime DataEntrada { get; set; }
        public bool Covid { get; set; }
        [Display(Name ="Temperatura atual")]
        public float Temperatura { get; set; }
    }
}
