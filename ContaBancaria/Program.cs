using ContaBancariaExercicio;

ContaBancaria conta = new ContaBancaria();
int opcao;

Console.WriteLine("Digite o nome do Titular: ");
string titular = Console.ReadLine();

do
{
    Console.WriteLine("\nDigite uma opção: \n1 - Depositar \n2 - Sacar \n3 - Verificar Saldo \n4 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nDigite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);
            break;
        case 2:
            Console.WriteLine("\nDigite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);
            break;
        case 3:
            Console.WriteLine($"\nNome do Titular: {titular}\nValor do Saldo: {conta.GetSaldo()}" );
            break;
        default:
            if (opcao != 4)
            {
                Console.WriteLine("\nOpção inválida, tente novamente.");
            }
            break;
    }

} while (opcao != 4);

