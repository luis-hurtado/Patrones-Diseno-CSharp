using System;

namespace Objetos.Parte3
{
    public class Demo
    {
        public static void Ejecutar()
        {

            Perro peluchin = new Perro
            {
                Nombre = "Peluchin"
            };
            Console.WriteLine(peluchin.Nombre);
            peluchin.HacerHuecos();
            peluchin.Altura=-1;

            // Ejemplo de paso por valor
            int randNum = 10;
            peluchin.CambiarValorVariable(randNum);
            Console.WriteLine("El valor de randNum fuera del metodo es: " + randNum);

            // Ejemplo paso por referencia
            CambiarNombreObjeto(peluchin);
            Console.WriteLine("El nombre del perro despues de llamar al metodo es: " + peluchin.Nombre);

            // Ejemplo de Polimorfismo
            Animal perrito = new Perro();
            Animal gatito = new Gato();

            Console.WriteLine("El perrito dice " + perrito.Sonido); // Ejecuta el método de la clase Perro
            Console.WriteLine("El gatito dice " + gatito.Sonido); // Ejecuta el método de la clase Gato

            // Ejemplo de Polimorfismo con arrays
            Animal[] animals = new Animal[4];
            animals[0] = perrito;
            animals[1] = gatito;

            Console.WriteLine("El perrito dice " + animals[0].Sonido); // Ejecuta el método de la clase Perro
            Console.WriteLine("El gatito dice " + animals[1].Sonido); // Ejecuta el método de la clase Gato

            // Ejemplo de Metodos estaticos
            AnimalDice(perrito);

            // perrito.hacerHuecos(); // no se puede
            ((Perro)perrito).HacerHuecos();

            // Ejemplo de clases abstractas - jirafa
            Jirafa jirafa = new Jirafa
            {
                Nombre = "Bridget"
            };
            Console.WriteLine(jirafa.Nombre);

        }

        public static void CambiarNombreObjeto(Perro fido)
        {
            fido.Nombre = "fido";
        }

        public static void AnimalDice(Animal animal)
        {
            Console.WriteLine("El animal dice " + animal.Sonido);
        }

    }

}