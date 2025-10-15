using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Caminhao : Veiculo
    {
        private double CapacidadeDeCarga;

        public double GetCapacidadeDeCarga()
        {
            return this.CapacidadeDeCarga;
        }

        public void SetCapacidadeDeCarga(double capacidadeDeCarga)
        {
            this.CapacidadeDeCarga = capacidadeDeCarga;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine("Capacidade de Carga: " + this.CapacidadeDeCarga + " kg");
        }
    }
}
