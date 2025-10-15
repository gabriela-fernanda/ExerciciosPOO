using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Roarrrrr");
        }

        public override void Exibir()
        {
            base.Exibir();
        }
    }
}
