
using System.Collections.Generic;

namespace Factory_Method.Demo.Despues.Cobra
{
    internal class MotorVistaCobra : IMotorVista
    {
        public string Renderizar(string vista, IDictionary<string, object> contexto)
        {
            return "Vista es renderizada por Cobra";
        }
    }
}
