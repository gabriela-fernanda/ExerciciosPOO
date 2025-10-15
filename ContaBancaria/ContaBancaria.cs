using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaExercicio
{
    public class ContaBancaria
    {
        private double Saldo;
        private string Titular;

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public string GetTitular()
        {
            return this.Titular;
        }
        public void SetTitular(string titular)
        {
            this.Titular = titular;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                Console.WriteLine("\nSaldo insuficiente para saque.");
            }
        }
    }
}
