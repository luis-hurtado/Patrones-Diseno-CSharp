using System.Collections.Generic;

namespace Iterator.Ejercicio
{
    internal class ColeccionProductos
    {
        private readonly List<Producto> productos = new List<Producto>();
               
        internal void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        internal IIterador CrearIterador()
        {
            return new IteradorListas(this);
        }

        private class IteradorListas : IIterador
        {
            private readonly ColeccionProductos coleccion;
            private int index;

            public IteradorListas(ColeccionProductos coleccionProductos)
            {
                coleccion = coleccionProductos;
            }

            public bool TieneSiguiente => (index < coleccion.productos.Count);

            public Producto Actual()
            {
                return coleccion.productos[index]; 
            }

            public void Siguiente()
            {
                index++;
            }
        }

    }
}