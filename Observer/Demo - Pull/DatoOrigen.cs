using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DemoPull
{
    internal class DatoOrigen : SujetoObservable
    {
        int dato;

        public int Dato { 
            get => dato; 
            set { 
                dato = value;
                ActualizarObservadores();
            } 
        }
    }
}
