using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo patron mediador!");
            Solucion.Demo.Ejecutar();

            Console.WriteLine("\n\nEjemplo con observer patron mediador!");
            Observer.Demo.Ejecutar();

            Console.WriteLine("\n\nEjercicio patron mediador!");
            Ejercicio.Demo.Ejecutar();

            Console.WriteLine("\n\nTarea patron mediador!");
            Tarea.Demo.Ejecutar();

            Console.ReadKey();
        }
    }
}
