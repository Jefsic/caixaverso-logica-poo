using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Bebida : Produto
    {
        public bool Gelada { get; set; }

        public Bebida(string nome, double preco, bool gelada)
            : base(nome, preco)
        {
            Gelada = gelada;
        }

        // Se a bebida estiver gelada, acrescenta 10% no preço
        public override double CalcularPreco()
        {
            return Gelada ? Preco * 1.1 : Preco;
        }
    }
}
