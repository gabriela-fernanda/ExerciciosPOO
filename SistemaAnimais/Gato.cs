using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade)
        {
        }
        public override string EmitirSom()
        {
            return "Miau Miau";
        }
    }
}
