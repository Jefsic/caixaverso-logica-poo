// Exercício 4: Cadastro de aluno
// Autor: Jefferson Siqueira Costa
// Data: 11/09/2025

using System;
using System.Numerics;

namespace Aula1;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        double nota1;
        double nota2;
        double nota3;
        double media;
        string resultado;

        //Entrada de dados
        Console.Clear();
        Console.WriteLine($"Informe o nome do aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine($"Informe a idade do aluno: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Informe a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Informe a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Informe a terceira nota: ");
        nota3 = double.Parse(Console.ReadLine());

        //Calcular resultado
        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            resultado = "aprovado";
        }
        else if (media > 5 && media < 7)
        {
            resultado = "em recuperação";
        }
        else
        {
            resultado = "reprovado";
        }

        //Mostrar resultado
        Console.Clear();
        Console.WriteLine($"O aluno {nome} tem {idade} anos, a média foi {media} e o resultado foi: {resultado}!");

        Console.WriteLine("\nDigite qualquer tecla para encerrar...");
        Console.ReadKey();

    }
}