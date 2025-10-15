using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public abstract class Pagamento
    {
        public decimal Valor;
        public DateTime DataPagemnto;

        public abstract void ProcessarPagamento(DateTime data, decimal valor);

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

        public void setDataPagamento(DateTime dataPagamento)
        {
            DataPagemnto = dataPagamento;
        }
    }
}
