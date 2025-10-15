using SistemaPagamento;

Console.WriteLine("Sistema de Pagamentos");

Console.WriteLine("\n     Cartão de credito");
Pagamento pagamentoCartao = new PagamentoCartaoCredito("1234 5678 9876 5432", 150.75, DateTime.Now);
pagamentoCartao.ProcessarPagamento();

Console.WriteLine();

Console.WriteLine("\n     Boleto");
Pagamento pagamentoBoleto = new PagamentoBoleto("23793.38127 60000.000008 04000.123456 1 67890000002005", 200.50, DateTime.Now);
pagamentoBoleto.ProcessarPagamento();