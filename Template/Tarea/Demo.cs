using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Tarea
{
    internal class Demo
    {
        internal static void Ejecutar()
        {

            Trabajador jose = new Bombero("Jose");
            jose.RutinaDiaria();

            Console.WriteLine();
            Trabajador mario = new Cartero("Mario");
            mario.RutinaDiaria();

            Console.WriteLine();
            Trabajador raul = new Obrero("Raul");
            raul.RutinaDiaria();

            Console.WriteLine();
            Trabajador alfredo = new Oficinista("Alfredo");
            alfredo.RutinaDiaria();
        }
    }
}
