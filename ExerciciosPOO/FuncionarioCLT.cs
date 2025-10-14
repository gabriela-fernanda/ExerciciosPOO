using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class FuncionarioCLT : Funcionario
    {
        private double Bonus;

        public override double CalcularSalarioFinal()
        {
            return this.GetSalarioBase() + this.Bonus;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Bônus: " + this.Bonus);
            Console.WriteLine("Salário Final: " + this.CalcularSalarioFinal());
        }

        public void SetBonus(double bonus)
        {
            this.Bonus = bonus;
        }
    }
}
