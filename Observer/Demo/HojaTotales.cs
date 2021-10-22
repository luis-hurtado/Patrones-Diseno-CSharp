using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Demo
{
    internal class HojaTotales : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Actualizar el monto total de las ventas"); ;
        }
    }
}
