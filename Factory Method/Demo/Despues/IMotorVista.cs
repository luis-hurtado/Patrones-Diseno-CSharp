using System.Collections.Generic;

namespace Factory_Method.Demo.Despues
{
    internal interface IMotorVista
    {
        string Renderizar(string vista, IDictionary<string, object> contexto);
    }
}