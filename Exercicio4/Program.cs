using Exercicio4.Entidades;
using Exercicio4.Servicos;
using System;
using System.Collections.Generic;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerador de pacotes de venda");
            Console.Write("Quantos itens para o respectivo pacote? ");
            int quantidadeDeItens = int.Parse(Console.ReadLine());

            List<Item> itens = new List<Item>();

            for (int i = 0; i < quantidadeDeItens; i++)
            {
                Console.Write($"Informe o nome do item #{i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Informe o valor do item #{i + 1}: ");
                double valor = double.Parse(Console.ReadLine());

                Item item = new Item(nome, valor);

                itens.Add(item);
            }

            Pacote pacote = new Pacote(DateTime.Now, new GeradorDeTaxaMG(), itens);

            pacote.InformarPacote();

            Console.Read();
        }
    }
}
