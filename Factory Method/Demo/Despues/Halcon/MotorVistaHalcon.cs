using Factory_Method.Demo.Despues.Cobra;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Demo.Despues.Halcon
{
    internal class MotorVistaHalcon : IMotorVista
    {
        public string Renderizar(string vista, IDictionary<string, object> contexto)
        {
            return "Vista es renderizada por Halcon";
        }
    }
}
