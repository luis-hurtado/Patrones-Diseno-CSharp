using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Antes.Demo.Ejecutar();
            Despues.Demo.Ejecutar();
            Console.ReadKey();
            Despues.Demo2.EjecutarOtroMetodo();
            Console.ReadLine();
        }
    }
}
