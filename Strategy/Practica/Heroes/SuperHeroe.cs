using Strategy.Practica.Habilidad;
using System;

namespace Strategy.Practica.Heroes
{
    public abstract class SuperHeroe: ISuperHeroes
    {
        private ISuperPoder _poder;
        String Nombre { get; set; }

        protected SuperHeroe(ISuperPoder poder, string nombre)
        {
            _poder = poder;
            Nombre = nombre;
        }

        public void CambiarSuperPoder(ISuperPoder poder)
        {
            Console.WriteLine ($"{Nombre} cabio su poder");
            _poder = poder;
        }

        public void UsarHabilidades() => Console.WriteLine( _poder.UsarPoder());

        public void ObtenerNombreReal()
        {
            Console.WriteLine($"Hola, Mi nombre real es {Nombre}");
        }

        public void PerderPoderes()
        {
            Console.WriteLine("Ho no, he perdido mis poderes");
            _poder = new PersonaComun();
        }
    }
}
