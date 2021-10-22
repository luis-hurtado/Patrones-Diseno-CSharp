using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Despues
{
    public abstract class Manejador
    {
        protected Manejador siguiente;

        protected Manejador(Manejador siguiente)
        {
            this.siguiente = siguiente;
        }

        public void Manejar(HttpRequest request) 
        { 
            if(ImplementarManejo(request))
                return;

            if(siguiente != null)
                siguiente.Manejar(request);
        }

        public abstract bool ImplementarManejo(HttpRequest request);
    }
}
