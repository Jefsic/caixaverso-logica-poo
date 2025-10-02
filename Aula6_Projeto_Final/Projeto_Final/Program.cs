using MiniHackathon;
using Projeto_Final;
using System;
using System.Collections.Generic;

namespace MiniHackathon
{
    class Program
    {
        static void Main()
        {
            // Cardápio
            var menu = new List<Produto>
            {
                new Produto("Hambúrguer", 15.0),
                new Produto("Batata Frita", 8.0),
                new Bebida("Refrigerante", 6.0, true),
                new Bebida("Suco Natural", 7.0, false)
            };

            var pedido = new List<Produto>();
            int opcao;

            do
            {
                Console.WriteLine("\n--- Menu ---");
                for (int i = 0; i < menu.Count; i++)
                    Console.WriteLine($"{i + 1} - {menu[i].Nome} (R$ {menu[i].CalcularPreco():0.00})");

                Console.WriteLine("0 - Finalizar Pedido");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine() ?? "0");

                if (opcao > 0 && opcao <= menu.Count)
                {
                    pedido.Add(menu[opcao - 1]);
                    Console.WriteLine($"{menu[opcao - 1].Nome} adicionado!");
                }
            }
            while (opcao != 0);

            double total = 0;
            Console.WriteLine("\n--- Pedido ---");
            foreach (var item in pedido)
            {
                Console.WriteLine($"{item.Nome} - R$ {item.CalcularPreco():0.00}");
                total += item.CalcularPreco();
            }
            Console.WriteLine($"Total: R$ {total:0.00}");
        }
    }
}
