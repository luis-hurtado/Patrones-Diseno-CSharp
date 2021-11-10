using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Ejercicio
{
    internal interface IComponente
    {
        string Ruta { get; set; }
        void Mover(string destino);
        void Eliminar();
    }
}
