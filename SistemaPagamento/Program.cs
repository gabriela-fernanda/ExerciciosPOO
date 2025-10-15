using SistemaPagamento;

Console.WriteLine("Informe o valor a ser pago: ");
var valor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe a forma de pagamento: 1 - Boleto, 2 - Cartão de Crédito");
var formaPagamento = Convert.ToInt32(Console.ReadLine());

if(formaPagamento == 1)
{
    var pagamento = new PagamentoBoleto();
    pagamento.ProcessarPagamento(DateTime.Now, valor);
}
else if(formaPagamento == 2)
{
    var pagamento = new PagamentoCartaoCredito();
    pagamento.ProcessarPagamento(DateTime.Now, valor);
}
else
{
    Console.WriteLine("Forma de pagamento inválida.");
}