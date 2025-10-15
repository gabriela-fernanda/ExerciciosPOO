using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }

        public override void Exibir()
        {
            base.Exibir();
        }
    }
}
