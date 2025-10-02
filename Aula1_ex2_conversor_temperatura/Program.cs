// Exercício 2: Conversor de temperatura
// Autor: Jefferson Siqueira Costa
// Data: 11/09/2025

using System;
using System.Numerics;

namespace Aula1;

class Program
{
    static void Main(string[] args)
    {
        double temperaturaInicial;
        double temperaturaF;
        double temperaturaK;

        //fórmula matemática para conversão: Fahrenheit = (°C × 9 / 5) +32
        //fórmula matemática para a conversão Kelvin = °C + 273.15

        Console.Clear();
        Console.WriteLine("Digite a temperatura em graus Celsius: ");
        temperaturaInicial = double.Parse(Console.ReadLine());
        temperaturaF = (temperaturaInicial * (9 / 5)) +32;
        temperaturaK = (temperaturaInicial + 273.15);

        Console.Clear();
        Console.WriteLine($"Conversão Fahrenheit: {temperaturaInicial} graus Celsius equivale a {temperaturaF} graus Fahrenheit!");
        Console.WriteLine();
        Console.WriteLine($"Conversão Kelvin: {temperaturaInicial} graus Celsius equivale a {temperaturaK} graus Kelvin!");

        Console.WriteLine("\nDigite qualquer tecla para encerrar...");
        Console.ReadKey();

    }

}





