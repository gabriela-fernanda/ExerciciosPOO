using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaPagamento
{
    public class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento(DateTime data, decimal valor)
        {
            this.setValor(valor);
            this.setDataPagamento(data);

            Console.WriteLine("Pagamento efetuado com boleto");
            Console.WriteLine(data);
        }
    }
}
