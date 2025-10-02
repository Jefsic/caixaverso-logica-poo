// Exercício 3: Classificador de números
// Autor: Jefferson Siqueira Costa
// Data: 11/09/2025

using System;
using System.Numerics;

namespace Aula1;

class Program
{
    static void Main(string[] args)
    {
        int numeroInicial;
        string testeParOuImpar;
        string testePositivoOuNegativo;
        string testeZero;

        Console.Clear();
        Console.WriteLine($"Informe um número inteiro: ");
        numeroInicial = int.Parse(Console.ReadLine());

        testeParOuImpar = (numeroInicial % 2) == 0 ? "par" : "impar";
        testePositivoOuNegativo = (numeroInicial > 0) ? "positivo" : "negativo";
        testeZero = numeroInicial == 0 ? "igual a zero" : "diferente de zero";

        Console.WriteLine($"O número informado ({numeroInicial}) é {testeZero}: é {testeParOuImpar} e {testePositivoOuNegativo}!");

        Console.WriteLine("\nDigite qualquer tecla para encerrar...");
        Console.ReadKey();

    }
}

 