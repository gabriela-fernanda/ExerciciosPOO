using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Animal
    {
        private string Nome;
        private int Idade;

        public string GetNome()
        {
            return this.Nome;
        }

        public int GetIdade() 
        {
            return this.Idade;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }

        public virtual void EmitirSom()
        {

        }

        public virtual void Exibir()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            EmitirSom();
        }
    }
}
