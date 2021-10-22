using System;

namespace Strategy.Despues
{
    internal class AlmacenImagenes
    {
        // atributos
        private ICompresor compresor;
        private IFiltro filtro;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="compresor"></param>
        /// <param name="filtro"></param>
        public AlmacenImagenes(ICompresor compresor, IFiltro filtro)
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
            compresor.Comprimir();

            // Paso2: Aplicar el filtro seleccionado
            filtro.Aplicar();

            // Paso3: guardar la imagen a la base de datos
            Console.WriteLine($"Se guardo la imagen {imagenSeleccionada} a la base de datos...");

        }
    }
}