using Strategy.Tarea.Antivirus;
using System;

namespace Strategy.Tarea
{
    internal class Demo
    {
        internal static void Ejecutar()
        {
            Console.WriteLine("Strategy Pattern - Ejercicio");

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("--------- Antivirus Simple ---------");
            Console.WriteLine("------------------------------------");
            IEstrategia estrategia = new AntivirusSimple();
            Contexto contexto = new Contexto(estrategia);
            contexto.Ejecutar();

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------- Antivirus Avanzado --------");
            Console.WriteLine("------------------------------------");
            contexto.Estrategia = new AntivirusAvanzado(); 
            contexto.Ejecutar();
        }
    }
}
