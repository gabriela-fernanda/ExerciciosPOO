using ExerciciosPOO;

Funcionario[] funcionarios;
int qtdFuncionarios;

Console.WriteLine("Informe quantos funcionarios quer cadastrar: ");
qtdFuncionarios = int.Parse(Console.ReadLine());

funcionarios = new Funcionario[qtdFuncionarios];

void InfoEmComum(Funcionario[] funcionarios,int i)
{
    Console.WriteLine($"Digite o nome do funcionário: ");
    funcionarios[i].SetNome(Console.ReadLine());
    Console.WriteLine($"Digite o salário base do funcionário: ");
    funcionarios[i].SetSalarioBase(double.Parse(Console.ReadLine()));
}


for (int i = 0; i < qtdFuncionarios; i++)
{
    Console.WriteLine("O funcionario é CLT ou PJ? (1 - PJ OU 2 - CLT)");
    int tipo = int.Parse(Console.ReadLine());

    if (tipo == 1) 
    {
        funcionarios[i] = new FuncionarioPJ();
        InfoEmComum(funcionarios, i);
        Console.WriteLine($"Digite a quantidade de horas trabalhadas");
        ((FuncionarioPJ)funcionarios[i]).SetHorasTrabalhadas(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Digite o valor por hora");
        ((FuncionarioPJ)funcionarios[i]).SetValorHora(double.Parse(Console.ReadLine()));
    }
    else
    {
        funcionarios[i] = new FuncionarioCLT();
        InfoEmComum(funcionarios, i);
        Console.WriteLine($"Digite o valor do bonus: ");
        ((FuncionarioCLT)funcionarios[i]).SetBonus(double.Parse(Console.ReadLine()));
    }
}

for (int i = 0; i < qtdFuncionarios; i++)
{
    Console.WriteLine();
    funcionarios[i].ExibirInfo();
    Console.WriteLine("-------------------");
}
