using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{
    //Classe abstrata -> nao pode ser instanciada
    // e podde conter metodos abstratos (sem implementacao)
    abstract class Veiculo
    {
        //Construtores
        public Veiculo(string marca)
        {
            _marca = marca;
        }

        //Metodos
        //virtual -> permite a sobrescrita do metodo
        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Acelerar(int velocidade)
        {
            if(velocidade < 0)
            {
                throw new VelocidadeException();
            }
        }

        public abstract void AbrirPorta();

        //Fields (Atributos)
        private string _marca;

        private int _numeroPortas;

        //Propriedades(Gets/Sets)
        public Combustivel Combustivel { get; set; }

        public string Modelo { get; set; }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public int NumeroPortas
        {
            get { return _numeroPortas; }
            set { _numeroPortas = value; }
        }
    }
}
