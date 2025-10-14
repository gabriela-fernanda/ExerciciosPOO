﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public abstract class Funcionario
    {
        private string Nome;
        private double SalarioBase;

        public abstract double CalcularSalarioFinal();

        public virtual void ExibirInfo()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salário Base: " + this.SalarioBase);
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetSalarioBase(double salarioBase)
        {
            this.SalarioBase = salarioBase;
        }

        public double GetSalarioBase()
        {
            return this.SalarioBase;
        }
    }
}
