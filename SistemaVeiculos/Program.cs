using SistemaVeiculos;
using static System.Net.Mime.MediaTypeNames;

Veiculo[] veiculos;
int qtdVeiculos;

Console.WriteLine("Informe quantos veiculos quer cadastrar: ");
qtdVeiculos = int.Parse(Console.ReadLine());

veiculos = new Veiculo[qtdVeiculos];
void InfoEmComum(Veiculo[] veiculos, int i)
{
    Console.WriteLine($"Digite a marca do veiculo: ");
    veiculos[i].SetMarca(Console.ReadLine());
    Console.WriteLine($"Digite o modelo do veiculo: ");
    veiculos[i].SetModelo(Console.ReadLine());
    Console.WriteLine($"Digite o ano do veiculo: ");
    veiculos[i].SetAno(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < qtdVeiculos; i++)
{
    Console.WriteLine("Escolha o veiculo para cadastrar (1 - Carro OU 2 - Moto OU 3 - Caminhão)");
    int tipo = int.Parse(Console.ReadLine());

    if (tipo == 1)
    {
        veiculos[i] = new Carro();
        InfoEmComum(veiculos, i);
        Console.WriteLine($"Digite o número de portas do carro: ");
        ((Carro)veiculos[i]).SetNumeroPortas(int.Parse(Console.ReadLine()));
    }
    else if (tipo == 2)
    {
        veiculos[i] = new Moto();
        InfoEmComum(veiculos, i);
        Console.WriteLine($"Digite a cilindrada da moto: ");
        ((Moto)veiculos[i]).SetCilindradas(int.Parse(Console.ReadLine()));
    }
    else
    {
        veiculos[i] = new Caminhao();
        InfoEmComum(veiculos, i);
        Console.WriteLine($"Digite a capacidade de carga do caminhão: ");
        ((Caminhao)veiculos[i]).SetCapacidadeDeCarga(double.Parse(Console.ReadLine()));
    }
}

for (int i = 0; i < qtdVeiculos; i++)
{
    Console.WriteLine();
    veiculos[i].ExibirInformacoes();
    Console.WriteLine("-------------------");
}