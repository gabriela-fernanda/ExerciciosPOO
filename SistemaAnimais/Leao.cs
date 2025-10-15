using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Leao : Animal
    {
        public override string EmitirSom()
        {
            return "Roarrrrr";
        }

        public Leao(string nome, int idade) : base(nome, idade)
        {
        }
    }
}
