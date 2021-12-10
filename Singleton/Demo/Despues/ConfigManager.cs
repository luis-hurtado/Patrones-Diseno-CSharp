using System.Collections.Generic;

namespace Singleton.Demo.Despues
{
    internal class ConfigManager
    {
        private IDictionary<string, object> settings = new Dictionary<string, object>();
        private static ConfigManager instanciaUnica;

        private ConfigManager() {}

        public static ConfigManager GetInstancia()
        {
            if (instanciaUnica == null)
                instanciaUnica = new ConfigManager();
            return instanciaUnica;
        }

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
