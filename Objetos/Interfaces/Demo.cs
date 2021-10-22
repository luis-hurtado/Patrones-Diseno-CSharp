using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Interfaces
{
    public class Demo
    {
        public static void Ejecutar(int anio)
        {
            ICalculadoraImpuesto calculadora = GetCalculadora(anio);
            var impuesto = calculadora.CalcularImpuesto();
            Console.WriteLine($"El impuesto calculado para el año {anio} es: {impuesto} ");
        }


        // En una aplicacion de la vida real utilizariamos dependenci injection.
        private static ICalculadoraImpuesto GetCalculadora(int anio)
        {
            if (anio == 2020)
                return new CalculadoraImpuesto2020();
            else
                return new CalculadoraImpuesto2021();
        }
    }
}
