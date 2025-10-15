using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Au Au";
        }

        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }
    }
}
