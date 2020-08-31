using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.NAC1.Web.Models
{
    public class Campeoes
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public Rota Rotas { get; set; }
        public int Preco { get; set; }
        public bool Rework { get; set; }
    }
}
