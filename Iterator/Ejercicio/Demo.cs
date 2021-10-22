using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Ejercicio
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var coleccion = new ColeccionProductos();
            coleccion.Agregar(new Producto(id: 1, descripcion: "Tornillos", cantidad: 100, precio: 5.5));
            coleccion.Agregar(new Producto(id: 2, descripcion: "Martillo", cantidad: 10, precio: 25.5));
            coleccion.Agregar(new Producto(id: 3, descripcion: "Pegamento", cantidad: 25, precio: 17.0));

            IIterador iterador = coleccion.CrearIterador();
            // Iteramos nuestro historial para mostrarlo en pantalla
            while (iterador.TieneSiguiente)
            {
                Console.WriteLine(iterador.Actual());
                iterador.Siguiente();
            }
        }
    }
}
