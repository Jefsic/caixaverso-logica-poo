using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c = new ContaCorrente();

            Console.WriteLine("Digite o valor a depositar:");
            c.Depositar(double.Parse(Console.ReadLine()));
          
            Console.WriteLine("Digite o valor a sacar:");
            c.Sacar(double.Parse(Console.ReadLine()));
              
            Console.WriteLine($"Saldo atual: {c.ConsultarSaldo()}");
            Console.WriteLine("Tecle qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}