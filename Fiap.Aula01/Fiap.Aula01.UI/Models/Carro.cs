using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{
    class Carro : Veiculo, ICompeticao
    {
        //Construtor
        public Carro(string marca) : base(marca)
        {
           
        }

        //Metodos
        public void Largar()
        {
            Console.WriteLine("Carro em modo de largada");
        }

        public override void AbrirPorta()
        {
            Console.WriteLine("Carro abrindo a porta");
        }

        //Sobrescrever o metodo acelerar
        public override void Acelerar()
        {
            Console.WriteLine("Carro acelerando");
        }


        //Propriedades (Gets/Sets)
        //props -> tab tab
        public int PortaNalas { get; set; }
        public int Ano { get; set; }

    }
}
