//Propriedades
//Crie a classe Produto com:
//Propriedade Nome (string)
//Propriedade Preco(double) que não permite valor negativo.
//No Main, teste atribuir um preço negativo e mostre a mensagem de erro no set.

using System;

class Produto
{
    private string? _nome;
    public string? Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }


    private double _preco;
    public double Preco

    {
        get { return _preco; }
        set
        {
            if (value >= 0)
            {
                _preco = value;
                Console.WriteLine($"Você cadastrou o produto {Nome} com o preço de {Preco} reais!");
            }
            else
            {
                Console.WriteLine("O preço do produto não pode ser negativo!");
            }
        }

    }

}