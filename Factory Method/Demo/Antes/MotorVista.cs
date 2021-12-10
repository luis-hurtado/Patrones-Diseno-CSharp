using System.Collections.Generic;

namespace Factory_Method.Demo.Antes
{
    internal class MotorVista
    {
        public string Renderizar(string vista, IDictionary<string, object> contexto)
        {
            return "Vista es renderizada por Cobra";
        }
    }
}
