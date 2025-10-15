using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Carro : Veiculo
    {
        private int NumeroPortas;

        public int GetNumeroPortas()
        {
            return this.NumeroPortas;
        }
        public void SetNumeroPortas(int numeroPortas)
        {
            this.NumeroPortas = numeroPortas;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine("Número de Portas: " + this.NumeroPortas);
        }
    }
}
