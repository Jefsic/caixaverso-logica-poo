using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int opcaoUsuario;

        ContaBancaria c = new ContaBancaria();
        Console.Clear();

        do
        {
            Console.Clear();
            Console.WriteLine("Conta bancária");
            Console.WriteLine("==============");
            Console.WriteLine("Escolha um operação bancária conforme opções abaixo:\n");
            Console.WriteLine("Digite 1 para depositar");
            Console.WriteLine("Digite 2 para sacar");
            Console.WriteLine("Digite 3 para exibir o saldo");
            Console.WriteLine("Digite 4 para encerrar a aplicação");
            opcaoUsuario = int.Parse(Console.ReadLine());

            switch (opcaoUsuario)
            {
                case 1:
                    Console.WriteLine("Digite o valor a ser depositado:");
                    c.Depositar(double.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.WriteLine("Digite o valor a ser sacado:");
                    c.Sacar(double.Parse(Console.ReadLine()));
                    break;

                case 3:
                    c.ExibirSaldo();
                    break;

                case 4:
                    Console.Clear();
                    System.Console.WriteLine("Programa encerrado!\n");
                    break;

                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
        }
        while (opcaoUsuario != 4);

    }

}