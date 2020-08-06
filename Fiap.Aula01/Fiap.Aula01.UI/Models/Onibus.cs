using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{
    class Onibus : Veiculo
    {
        //Construtor com a marca e lotacao
        public Onibus(string marca, int lotacao) : base(marca)
        {
            Lotacao = lotacao;
        }
        //Propriedades
        public int Lotacao { get; set; }
        public int Rodas { get; set; }

        //Metodos
        public override void AbrirPorta()
        {
            Console.WriteLine("Abrindo a porta do onibus");
        }
    }
}
