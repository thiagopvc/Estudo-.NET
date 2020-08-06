using Fiap.Aula01.UI.Exercicio;
using Fiap.Aula01.UI.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Aula01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro("Ford")
            {
                Ano = 2016,
                Modelo = "Ka"
            };

            carro.Marca = "Ford"; //Set
            carro.Combustivel = Combustivel.Flex;

            Console.WriteLine(carro.Marca); //Get

            //Lista de onibus
            IList<Onibus> onibus = new List<Onibus>();

            //Adicionar dois objetos na lista
            onibus.Add(new Onibus("Marca", 12));
            onibus.Add(new Onibus("Marcao", 22));

            foreach(var item in onibus)
            {
                Console.WriteLine(item.Marca + " " + item.Lotacao);
            }

            //Tratamento de excecao
            try
            {
                carro.Acelerar(-10);
            }
            catch(VelocidadeException e)
            {
                Console.WriteLine(e.Message);
            }

            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca(10);

            contaCorrente.Saldo = 100;
            contaCorrente.Numero = 1;
            contaCorrente.Agencia = 1;
            contaCorrente.Tipo = TipoConta.Comum;

            contaPoupanca.Agencia = 2;
            contaPoupanca.Numero = 2;
            contaPoupanca.Saldo = 500;
            contaPoupanca.Taxa = 40;

            contaCorrente.Depositar(50);
            contaCorrente.Retirar(100);
            Console.WriteLine(contaCorrente.Saldo);

            contaPoupanca.Depositar(50);
            contaPoupanca.CalculaReturnaInvestimento();
            contaPoupanca.Retirar(50);
            Console.WriteLine(contaPoupanca.Saldo);

        }
    }
}
