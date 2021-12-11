using System;
using System.Collections.Generic;
using System.Text;
using Exercicio4.Servicos;

namespace Exercicio4.Entidades
{
    class Pacote
    {
        public DateTime DataPedido { get; set; }
        public double ValorTotal { get; set; }

        public List<Item> Items = new List<Item>();

        private ITaxa _geradorTaxa;
        
        public Pacote(DateTime dataPedido, ITaxa geradorDeTaxa, List<Item> items)
        {
            Items = items;

            SomarValores();

            DataPedido = dataPedido;
            _geradorTaxa = geradorDeTaxa;
            ValorTotal = _geradorTaxa.GerarTaxa(ValorTotal);
        }

        private void SomarValores()
        {
            foreach (var item in Items)
            {
                ValorTotal += item.Valor;
            }
        }

        public void InformarPacote()
        {
            Console.WriteLine("Pacote gerado:");
            Console.WriteLine($"Data Pedido: {DataPedido}");
            Console.WriteLine($"Valor Total: {ValorTotal}");
            Console.WriteLine("Itens no pacote:");

            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Nome}: {item.Valor}");
            }
        }
    }
}
