//1489 - caixaverso 03 - Dev Back-end C#
//Aula 2 - Exercicio 4 - Tratamento de erros - 16/09/2025
//Aluno: Jefferson Siqueira Costa

using System;
using System.Buffers;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            Console.Clear();
            Console.WriteLine("Sr. usuário, por gentileza digite um número: ");
            int numDigitado = int.Parse(Console.ReadLine());

            //Teste para gerar OU NÃO o erro
            numDigitado = 10 / numDigitado;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Entrada inválida!  Erro:" + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divisão por zero não existe!  Erro: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\n Fim do processo!");
        }
    }
}