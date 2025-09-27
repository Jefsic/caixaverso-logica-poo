using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Conta
    {
        protected double saldo;
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }
    }
}
