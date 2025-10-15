using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoBarras;

        public void SetNumeroCartao(string codigoBarras)
        {
            this.CodigoBarras = codigoBarras;
        }

        public string GetNumeroCartao()
        {
            return this.CodigoBarras;
        }

        public PagamentoBoleto(string codigoBarras, double valor, DateTime dataPagamento)
        {
            this.CodigoBarras = codigoBarras;
            this.Valor = valor;
            this.DataPagemnto = dataPagamento;
        }
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Codigo de Barras: " + this.CodigoBarras);
            Console.WriteLine("Valor do pagamento: " + this.Valor);
            Console.WriteLine("Data do pagamento: " + this.DataPagemnto);
        }
    }
}
