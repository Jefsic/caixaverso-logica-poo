//1489 - caixaverso 03 - Dev Back-end C#
//Aula 2 - Exercicio 3 - Dicionarios - 16/09/2025
//Aluno: Jefferson Siqueira Costa

using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> estoque = new Dictionary<string, int>();
        string nomeInserido;
        int qtdeInserida;
        int encerraContinua;

        Console.Clear();

        do
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do produto:");
            nomeInserido = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto");
            qtdeInserida = int.Parse(Console.ReadLine());

            //Inserindo elementos no dicionario
            estoque.Add(nomeInserido, qtdeInserida);

            Console.WriteLine("Tecle 1 para continuar, 0 para encerrar");
            encerraContinua = int.Parse(Console.ReadLine());

        }  while (encerraContinua != 0);

        Console.Clear ();
        Console.WriteLine("itens cadastrados:");
        Console.WriteLine();
        Console.WriteLine("Produto - Quantidade");

        foreach (KeyValuePair<string,int> item in estoque)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

    }


}

