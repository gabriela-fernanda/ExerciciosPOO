using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public abstract class Pagamento
    {
        public double Valor;
        public DateTime DataPagemnto;

        public abstract void ProcessarPagamento();

        public double GetValor()
        {
            return this.Valor;
        }

        public DateTime GetDataPagamento()
        {
            return this.DataPagemnto;
        }

        public void SetValor(double valor)
        {
            this.Valor = valor;
        }

        public void SetDataPagamento(DateTime dataPagamento)
        {
            this.DataPagemnto = dataPagamento;
        }
    }
}
