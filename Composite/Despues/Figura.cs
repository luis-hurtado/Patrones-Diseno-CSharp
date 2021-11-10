using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Despues
{
    internal class Figura:IComponente
    {
        public void Dibujar()
        {
            Console.WriteLine("Dibujando la figura");
        }

        public void Mover()
        {
            Console.WriteLine("Moviendo la figura");
        }
    }
}
