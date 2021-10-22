using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Polimorfismo
{
    public class Demo
    {
        public static void Ejecutar()
        {
            // Ejemplo de Polimorfismo
            Animal perrito = new Perro();
            Animal gatito = new Gato();

            // Demostracion de los sonidos por animal
            Console.WriteLine("El perrito dice " + perrito.Sonido); // Ejecuta el método de la clase Perro
            Console.WriteLine("El gatito dice " + gatito.Sonido); // Ejecuta el método de la clase Gato

            // Polimorfismo en Propiedad
            AnimalDice(gatito);
            // Polimorfismo en Metodo
            AnimalJuega(gatito);

            //perrito.hacerHuecos(); // no se puede
            //((Perro)gatito).HacerHuecos();
            AnimalHaceHuecos(gatito);

        }

        private static void AnimalHaceHuecos(Animal animal)
        {
            if (animal is Perro perro) 
                perro.HacerHuecos();
            else
                Console.WriteLine("Este animalito no hace huecos");
        }

        static void AnimalDice(Animal animal)
        {
            Console.WriteLine("El animal dice " + animal.Sonido);
        }

        static void AnimalJuega(Animal animal)
        {
            animal.Jugar();
        }
    }
}
