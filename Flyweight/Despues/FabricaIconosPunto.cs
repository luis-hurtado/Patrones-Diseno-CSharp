using System;
using System.Collections.Generic;

namespace Flyweight.Despues
{
    internal class FabricaIconosPunto
    {
        private IDictionary<TipoPunto, IconosPunto> iconos = new Dictionary<TipoPunto, IconosPunto>();

        public IconosPunto IconoPorTipo(TipoPunto tipo)
        {
            // key          ->  Value
            // TipoPunto    ->  IconosPunto
            if (!iconos.ContainsKey(tipo))
            {
                var iconoPunto = new IconosPunto(tipo, ObtenerIcono(tipo));
                iconos[tipo] = iconoPunto;
            }

            return iconos[tipo];

        }

        private sbyte[] ObtenerIcono(TipoPunto tipo)
        {
            Console.WriteLine("recuperando la imagen para el tipo: " + tipo);
            return null;
        }
    }
}
