using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Antes
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var grupo1 = new Grupo();
            grupo1.AgregarElemento(new Figura()); // Cuadrado 1
            grupo1.AgregarElemento(new Figura()); // Cuadrado 2

            var grupo2 = new Grupo();
            grupo2.AgregarElemento(new Figura()); // Circulo 1
            grupo2.AgregarElemento(new Figura()); // Circulo 2

            var grupoRaiz = new Grupo();
            grupoRaiz.AgregarElemento(grupo1);
            grupoRaiz.AgregarElemento(grupo2);

            grupoRaiz.Dibujar();
        }
    }
}
