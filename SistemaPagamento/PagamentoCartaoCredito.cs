using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public class PagamentoCartaoCredito : Pagamento
    {
       
        public override void ProcessarPagamento(DateTime data, decimal valor)
        {
            this.setValor(valor);
            this.setDataPagamento(data);

            Console.WriteLine("Pagamento efetuado com cartão de credito");
            Console.WriteLine(data);
        }
    }
}
