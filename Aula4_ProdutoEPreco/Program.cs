class Program
{

    static void Main(string[] args)
    {

        Produto p = new Produto();

        Console.Clear();
        Console.WriteLine("Digite o nome do produto");
        p.Nome = Console.ReadLine();

        Console.WriteLine("Digite o preço do produto:");
        p.Preco = double.Parse(Console.ReadLine());
    }

}