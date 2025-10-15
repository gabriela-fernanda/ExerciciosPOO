using SistemaAnimais;

Animal[] animais = new Animal[3];

animais[0] = new Cachorro("Rex", 5);
animais[1] = new Gato("Mingau", 3);
animais[2] = new Leao("Simba", 7);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(animais[i].ToString());
    Console.WriteLine($"Som: {animais[i].EmitirSom()}\n");
    Console.WriteLine("-------------------");
}