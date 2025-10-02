//1489 - caixaverso 03 - Dev Back-end C#
//Exercicio 1 - Métodos - 16/09/2025
//Aluno: Jefferson Siqueira Costa

using System;
using System.Net.Http.Headers;

namespace Aula2;
class Program
{
    static void Main(string[] args)
    {

        double nota1;
        double nota2;
        double nota3;

        Console.Clear();
        Console.WriteLine("Digite a primeira nota; ");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a primeira nota; ");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a primeira nota; ");
        nota3 = double.Parse(Console.ReadLine());

        Console.Write(value: $"A média das notas {nota1}, {nota2} e {nota3} é {Media(nota1, nota2, nota3):F2}");
    }

    //método que calcula a média
    static double Media(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }

}