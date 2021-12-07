using System.Collections;

namespace Prototype.Ejercicio
{
    internal class Tienda
    {
        private Hashtable dispositivos = new Hashtable();

        public IDispositivo this[string nombre]
        {
            get
            {
                return dispositivos.ContainsKey(nombre)
                           ? dispositivos[nombre] as IDispositivo
                           : null;
            }

            set
            {
                dispositivos.Add(nombre, value);
            }
        }
    }
}
