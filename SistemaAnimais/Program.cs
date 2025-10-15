using SistemaAnimais;

Animal[] animais;
int qtdAnimais;

Console.WriteLine("Informe quantos animais quer cadastrar: ");
qtdAnimais = int.Parse(Console.ReadLine());

animais = new Animal[qtdAnimais];
void InfoEmComum(Animal[] animais, int i)
{
    Console.WriteLine($"Digite o nome do animal: ");
    animais[i].SetNome(Console.ReadLine());
    Console.WriteLine($"Digite a idade do animal: ");
    animais[i].SetIdade(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < qtdAnimais; i++)
{
    Console.WriteLine("Escolha o animal para cadastrar (1 - Cachorro OU 2 - Gato OU 3 - Leão)");
    int tipo = int.Parse(Console.ReadLine());

    if (tipo == 1)
    {
        animais[i] = new Cachorro();
        InfoEmComum(animais, i);
    }
    else if(tipo == 2)
    {
        animais[i] = new Gato();
        InfoEmComum(animais, i);
    }
    else
    {
        animais[i] = new Leao();
        InfoEmComum(animais, i);
    }
}

for (int i = 0; i < qtdAnimais; i++)
{
    Console.WriteLine();
    animais[i].Exibir();
    Console.WriteLine("-------------------");
}