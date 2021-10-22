using System;

namespace Strategy.Antes
{
    internal class AlmacenImagenes
    {
        // atributos
        private string compresor;
        private string filtro;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="compresor"></param>
        /// <param name="filtro"></param>
        public AlmacenImagenes(string compresor, string filtro)
        {
            // inicializamos los parametros
            this.compresor = compresor;
            this.filtro = filtro;
        }


        /// <summary>
        /// Algoritmo para guardar la imagen y aplicar
        /// el filtro y el compresor seleccionados.
        /// </summary>
        /// <param name="imagenSeleccionada"></param>
        internal void Guardar(string imagenSeleccionada)
        {
            // Paso1: Aplicar el algoritmo de compresion
            if (compresor == "jpeg")
            {
                Console.WriteLine("Se comprimio la imagen utilizando JPEG");
            }
            else if(compresor == "png")
            {
                Console.WriteLine("Se comprimio la imagen utilizando PNG");
            }
            else
            {
                Console.WriteLine("No se aplico ningun algoritmo de compresion");
            }

            // Paso2: Aplicar el filtro seleccionado
            if (filtro == "B&N")
            {
                Console.WriteLine("Se aplico el filtro Blanco y Negro a la imagen");
            }
            else if (filtro == "alta-resolucion")
            {
                Console.WriteLine("Se aplico el filtro de Alta Resolución a la imagen");
            }
            else
            {
                Console.WriteLine("No se aplico ningun filtro");
            }


            // Paso3: guardar la imagen a la base de datos
            Console.WriteLine($"Se guardo la imagen {imagenSeleccionada} a la base de datos...");

        }
    }
}