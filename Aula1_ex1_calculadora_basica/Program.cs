// Exercício 1: Calculadora básica
// Autor: Jefferson Siqueira Costa
// Data: 11/09/2025

using System;
using System.Numerics;

namespace Aula1;

class Program
{
    static void Main(string[] args)
    {
        int a = 8;
        int b = 2;

        Console.Clear();
        Console.WriteLine($"O resultado da soma é: {(a + b).ToString("F2")}");
        Console.WriteLine($"O resultado da subtração é: {(a - b).ToString("F2")}");
        Console.WriteLine($"O resultado da multiplicação é: {(a * b).ToString("F2")}");
        Console.WriteLine($"O resultado da divisão é: {(a / b).ToString("F2")}");

        Console.WriteLine("\nDigite qualquer tecla para continuar...");
        Console.ReadKey();

    }

}




