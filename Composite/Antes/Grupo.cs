using System;
using System.Collections.Generic;

namespace Composite.Antes
{
    internal class Grupo
    {
        List<object> elementos = new List<object>();

        public void AgregarElemento(Object item)
        {
            elementos.Add(item);
        }

        public void Dibujar()
        {
            foreach (var item in elementos)
            {
                if (item is Figura)
                    ((Figura)item).Dibujar();
                else if (item is Grupo)
                    ((Grupo)item).Dibujar();
            }
        }
    }
}
