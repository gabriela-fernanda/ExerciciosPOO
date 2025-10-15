using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Moto : Veiculo
    {
        private int Cilindradas;

        public int GetCilindradas()
        {
            return this.Cilindradas;
        }

        public void SetCilindradas(int cilindradas)
        {
            this.Cilindradas = cilindradas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine("Cilindradas: " + this.Cilindradas);
        }
    }
}
