using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Demo.Antes
{
    internal class Controlador
    {
        public void Renderizar(string nombreVista, IDictionary<string, object> contexto)
        {
            var motor = new MotorVista();
            var html = motor.Renderizar(nombreVista, contexto);
            Console.WriteLine(html);
        }
    }
}
