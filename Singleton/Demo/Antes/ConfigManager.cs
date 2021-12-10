using System.Collections.Generic;

namespace Singleton.Demo.Antes
{
    internal class ConfigManager
    {
        private IDictionary<string, object> settings = new Dictionary<string, object>();

        public void Set(string llave, object valor)
        {
            settings[llave] = valor;
        }

        public object Get(string llave)
        {
            object valor = null;
            if (settings.ContainsKey(llave))
                valor = settings[llave];
            return valor;
        }


    }
}
