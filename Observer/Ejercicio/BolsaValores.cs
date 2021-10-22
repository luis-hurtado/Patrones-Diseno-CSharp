using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Ejercicio
{
    internal class BolsaValores : SujetoObservable
    {
        private Resultados resultados;

        public Resultados Datos
        {
            get { return resultados; }
            set { 
                resultados = value;
                ActualizarObservadores();
            }
        }


    }
}
