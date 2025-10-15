using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public string NumeroCartao;

        public void SetNumeroCartao(string numeroCartao)
        {
            this.NumeroCartao = numeroCartao;
        }

        public string GetNumeroCartao()
        {
            return this.NumeroCartao;
        }

        public PagamentoCartaoCredito(string numeroCartao, double valor, DateTime dataPagamento)
        {
            this.NumeroCartao = numeroCartao;
            this.Valor = valor;
            this.DataPagemnto = dataPagamento;
        }
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Numero do cartao: " + this.NumeroCartao);
            Console.WriteLine("Valor do pagamento: " + this.Valor);
            Console.WriteLine("Data do pagamento: " + this.DataPagemnto);
        }
    }
}
