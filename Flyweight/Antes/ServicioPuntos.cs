using System.Collections.Generic;

namespace Flyweight.Antes
{
    internal class ServicioPuntos
    {
        public List<Punto> ObtenerPuntos()
        {
            List<Punto> puntos = new List<Punto>() {
                new Punto(1, 35, TipoPunto.CAFE, null),
                new Punto(2, 25, TipoPunto.ESCUELA, null),
                new Punto(3, 15, TipoPunto.GASOLINERIA, null),
                new Punto(1, 1, TipoPunto.HOSPITAL, null),
                new Punto(4, 5, TipoPunto.RESTAURANTE, null),
            };

            return puntos;
        }
    }
}
