using System;

namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Veiculo v = new Veiculo();
        Console.WriteLine("Demonstração classe Veiculo");
        v.Ligar();
        v.Marca = "Ford";
        Console.WriteLine();

        Moto m = new Moto();
        Console.WriteLine("Demonstração herança Moto");
        m.Ligar();
        m.Empinar();
        Console.WriteLine();

        Carro c = new Carro();
        Console.WriteLine("Demonstração herança Carro");
        c.Ligar();
        c.AbrirPortaMalas();

        Console.WriteLine("\nTecle qualquer tecla para continuar...");
        Console.ReadKey();

    }


}