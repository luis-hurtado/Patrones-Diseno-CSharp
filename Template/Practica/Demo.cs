using System;
using Template.Practica.RedesSociales;

namespace Template.Practica
{
    internal class Demo
    {
        internal static void Ejecutar()
        {
            
            RedSocial redSocial = null;
            Console.Write("Introduzca su nombre de usuari: ");
            string nombreUsuario = Console.ReadLine();
            Console.Write("Introduzca su contraseña: ");
            string password = Console.ReadLine();

            // Enter the message.
            Console.Write("Introduzca el mensaje: ");
            string mensaje = Console.ReadLine();

            Console.WriteLine("\nSeleccione la red social para publicar el mensaje.\n" +
                    "1 - Facebook\n" +
                    "2 - Twitter");
            int choice = int.Parse(Console.ReadLine());

            // Create proper network object and send the message.
            if (choice == 1)
            {
                redSocial = new Facebook(nombreUsuario, password);
            }
            else if (choice == 2)
            {
                redSocial = new Twitter(nombreUsuario, password);
            }
            redSocial.Post(mensaje);
        }
    }
}
