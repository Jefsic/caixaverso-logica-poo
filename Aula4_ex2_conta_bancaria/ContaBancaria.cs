
using System;
using System.Security.Cryptography;

class ContaBancaria
{
    private double _saldo;
    public double Saldo
    //não há necessidade de validar o SET, já está sendo tratado na entrada do valor
    {
        get { return _saldo; }
    }

    public void Depositar(double valor)
    {
        if (valor >= 0)
        {
            _saldo += valor;
            ExibirSaldo();
        }
        else
        {
            Console.WriteLine("Valor não pode ser negativo!  Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

    }

    public void Sacar(double valor)
    {
        if (valor >= 0)
        {
            _saldo -= valor;
            ExibirSaldo();
        }
        else
        {
            Console.WriteLine("Valor não pode ser negativo!  Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }
    }

    public void ExibirSaldo()
    {
        Console.Clear();
        Console.WriteLine($"O saldo atual é de {_saldo.ToString("F2")}");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();

    }

}