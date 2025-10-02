//1489 - caixaverso 03 - Dev Back-end C#
//Exercicio 2 - 16/09/2025
//Estruturas de repetição
//Aluno: Jefferson Siqueira Costa

using System;

class Program
{
    static void Main(string[] args)
    {
        int numDigitado;
        int somaNumeros = 0;

        Console.Clear();

        do
        {
            Console.WriteLine();   //gerar uma linha em branco antes da pergunta
            Console.WriteLine("Digite um número inteiro:   (ou zero para sair!)");
            numDigitado = int.Parse((Console.ReadLine()));

            Console.WriteLine($"Número digitado: {numDigitado}");

            somaNumeros = somaNumeros + numDigitado;

        } while (numDigitado != 0);

        Console.WriteLine($"A soma dos números digitados é: {somaNumeros}");

    }

}


