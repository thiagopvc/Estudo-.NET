using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Exercicio
{
    class ContaCorrente : Conta
    {
        public TipoConta Tipo { set; get; }

        public override void Depositar(decimal valor)
        {
            Saldo += valor; 
        }

        public override void Retirar(decimal valor)
        {
            if(Tipo == TipoConta.Comum && (Saldo - valor) < 0)
            {
                throw new Exception();
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}
