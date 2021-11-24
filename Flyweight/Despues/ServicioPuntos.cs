using System.Collections.Generic;

namespace Flyweight.Despues
{
    internal class ServicioPuntos
    {
        private FabricaIconosPunto fabrica;

        public ServicioPuntos(FabricaIconosPunto fabrica)
        {
            this.fabrica = fabrica;
        }

        public List<Punto> ObtenerPuntos()
        {
            List<Punto> puntos = new List<Punto>() {
                new Punto(1, 10, fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(2, 15, fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                new Punto(3, 20, fabrica.IconoPorTipo(TipoPunto.GASOLINERIA)),
                new Punto(1, 25, fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                new Punto(4, 30, fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
                new Punto(1, 35, fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(2, 40, fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                new Punto(3, 45, fabrica.IconoPorTipo(TipoPunto.GASOLINERIA)),
                new Punto(1, 50, fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                new Punto(4, 55, fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
                new Punto(1, 60, fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(2, 65, fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                new Punto(3, 70, fabrica.IconoPorTipo(TipoPunto.GASOLINERIA)),
                new Punto(1, 75, fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                new Punto(4, 80, fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
            };

            return puntos;
        }
    }
}
