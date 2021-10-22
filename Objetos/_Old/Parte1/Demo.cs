using System;

namespace Objetos.Parte1
{
    public class Demo
    {
        public static void Ejecutar()
        {
            Perro peluchin = new Perro();
            peluchin.Nombre = "Peluchin";
            Console.WriteLine(peluchin.Nombre);
            peluchin.HacerHuecos();
            peluchin.Altura = -1;

            int randNum = 10;
            peluchin.CambiarValorVariable(randNum);
            Console.WriteLine("El valor de randNum fuera del metodo es: " + randNum);

            CambiarNombreObjeto(peluchin);
            Console.WriteLine("El nombre del perro despues de llamar al metodo es: " + peluchin.Nombre);
        }

        public static void CambiarNombreObjeto(Perro fido)
        {
            fido.Nombre = "fido";
        }

    }

}