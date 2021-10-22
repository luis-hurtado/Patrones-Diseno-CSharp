using System;

namespace Observer.Ejercicio
{
    internal class Resultados
    {
        public Resultados(double precioIbm, double precioGoogle, double precioMicrosoft)
        {
            PrecioIbm = precioIbm;
            PrecioGoogle = precioGoogle;
            PrecioMicrosoft = precioMicrosoft;
        }

        public double PrecioIbm { get; }

        public double PrecioGoogle { get; }

        public double PrecioMicrosoft { get; }


    }
}
