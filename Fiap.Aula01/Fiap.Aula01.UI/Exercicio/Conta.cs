﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Exercicio
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }


        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);
    }
}
