using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Exercicio
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;

        public decimal Taxa { get; set; }

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public void CalculaReturnaInvestimento()
        {
            Console.WriteLine(Saldo * _rendimento);
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if(Saldo > valor)
            {
                Saldo -= valor + Taxa;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
