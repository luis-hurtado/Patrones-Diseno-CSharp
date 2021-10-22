using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DemoPull
{
    internal class HojaTotales : IObservador
    {
        DatoOrigen origen;

        public HojaTotales(DatoOrigen origen)
        {
            this.origen = origen;
        }

        public void Actualizar()
        {
            Console.WriteLine("Actualizar el monto total de las ventas con el valor:" + origen.Dato); 
        }
    }
}
