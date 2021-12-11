using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Entidades
{
    class Item
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
