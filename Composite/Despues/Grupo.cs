using System;
using System.Collections.Generic;

namespace Composite.Despues
{
    internal class Grupo : IComponente
    {
        List<IComponente> elementos = new List<IComponente>();

        public void AgregarElemento(IComponente item)
        {
            elementos.Add(item);
        }

        public void Dibujar()
        {
            foreach (var item in elementos)
            {
                item.Dibujar();
            }
        }

        public void Mover()
        {
            foreach (var item in elementos)
            {
                item.Mover();
            }
        }
    }
}
