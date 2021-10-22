using System;

namespace Objetos.Encapsulacion
{
    class Demo
    {
        public static void Ejecutar()
        {
            var cuenta = new Cuenta();
            // Ejemplo cuando el campo es  public
            //cuenta.balance = -1;
            //Ejemplo cuando el campo es privado y creamos una propiedad
            //cuenta.Balance = -1;
            //Ejemplo cuando utilizamos metodos
            cuenta.Depositar(17);
            cuenta.Retirar(5);
            Console.WriteLine("El estado del balance es: " + cuenta.Balance);
        }
    }
}
