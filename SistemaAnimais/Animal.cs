using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public abstract class Animal
    {
        private string Nome;
        private int Idade;

        public Animal(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
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

        //Podia fazer asaim ao ives de usar os métodos Set
        //public Animal(string nome, int idade)
        //{
        //    this.Nome = nome;
        //    this.Idade = idade;
        //}

        public abstract string EmitirSom();

        public override string ToString()
        {
            return $"Nome: {this.Nome}\nIdade: {this.Idade}";
        }
    }
}
