using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificacoes
{
    public class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando notificação genérica...");
        }
    }
}
