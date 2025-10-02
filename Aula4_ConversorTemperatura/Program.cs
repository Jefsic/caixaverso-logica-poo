using System;

class Program
{
    public static double valorConvertido;

    static void Main(string[] args)
    {
        Conversor c = new Conversor();

        Console.Clear();

        Console.WriteLine("Digite uma temperatura em Celsius:");
        valorConvertido = double.Parse(Console.ReadLine());
        Console.WriteLine($"Valor convertido de Celsius para Fahrenheit: " + c.CelsiusParaFahrenheit(valorConvertido).ToString("F2"));

        Console.WriteLine();
        Console.WriteLine("Digite uma temperatura em Fahrenheit:");
        valorConvertido = double.Parse(Console.ReadLine());
        Console.WriteLine($"Valor convertido de Fahrenheit para Celsius: " + c.FahrenheitParaCelsius(valorConvertido).ToString("F2"));

    }
}
