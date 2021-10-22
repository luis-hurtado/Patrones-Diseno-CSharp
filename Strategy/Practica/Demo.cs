using Strategy.Practica.Habilidad;
using Strategy.Practica.Heroes;
using System;

namespace Strategy.Practica
{
    public class Demo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Strategy Pattern - Ejercicio");

            Console.WriteLine();
            Console.WriteLine("El nuevo héroe SpiderMan se acerca");
            ISuperHeroes spiderman = new SpiderMan();
            spiderman.ObtenerNombreReal();
            spiderman.UsarHabilidades();
            spiderman.CambiarSuperPoder(new Golpear());
            spiderman.UsarHabilidades();
            spiderman.CambiarSuperPoder(new Volar());
            spiderman.UsarHabilidades();
            spiderman.PerderPoderes();
            spiderman.UsarHabilidades();

            Console.WriteLine();
            Console.WriteLine("El nuevo héroe Superman se acerca");
            ISuperHeroes superman = new Superman();
            superman.ObtenerNombreReal();
            superman.UsarHabilidades();

            Console.WriteLine();
            Console.WriteLine("El nuevo héroe Batman se acerca");
            ISuperHeroes batman = new Batman();
            batman.ObtenerNombreReal();
            batman.UsarHabilidades();
            
        }
    }
}
