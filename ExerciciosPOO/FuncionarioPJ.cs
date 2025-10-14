using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    internal class FuncionarioPJ : Funcionario
    {
        private int HorasTrabalhadas;
        private double ValorHora;
        public override double CalcularSalarioFinal()
        {
            return this.HorasTrabalhadas * this.ValorHora;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Horas Trabalhadas: " + this.HorasTrabalhadas);
            Console.WriteLine("Valor por Hora: " + this.ValorHora);
            Console.WriteLine("Salário Final: " + this.CalcularSalarioFinal());
        }

        public void SetHorasTrabalhadas(int horasTrabalhadas)
        {
            this.HorasTrabalhadas = horasTrabalhadas;
        }

        public void SetValorHora(double valorHora)
        {
            this.ValorHora = valorHora;
        }
    }
}
