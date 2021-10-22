using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases_Abstractas
{
    public class Demo
    {
        public static void Ejecutar()
        {
            //No se pueden crear instancias
            //Criatura criatura = new Criatura();
            Criatura criatura = new Jirafa
            {
                nombre = "Tomas",
                Altura = 4 // 4 mts
            };
            //criatura.MostrarVersion();
            Criatura.MostrarVersion();
            Console.WriteLine( "Mi tipo es " + criatura.ObtenerTipo());
            Console.WriteLine("Criatura nombre = "+criatura.nombre);
            criatura.EstablecerNombre("George");
            Console.WriteLine("Criatura nombre = " + criatura.nombre);


        }


    }
}
