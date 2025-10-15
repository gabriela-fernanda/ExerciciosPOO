using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau Miau");
        }

        public override void Exibir()
        {
            base.Exibir();
        }
    }
}
