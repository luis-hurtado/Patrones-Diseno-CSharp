using System;

namespace Decorator.Antes
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Datos normales");
            CloudStream stream = new CloudStream();
            stream.Escribir("Datos normales");

            Console.WriteLine("Datos confidenciales");
            CloudStream streamEncriptado = new CloudStreamEncriptado();
            streamEncriptado.Escribir("Datos confidenciales");

            Console.WriteLine("Datos multimedia");
            CloudStream streamComprimido = new CloudStreamComprimido();
            streamComprimido.Escribir("Datos multimedia");

            //Console.WriteLine("Datos multimedia");
            //CloudStream streamComprimido = new CloudStreamComprimido();
            //streamComprimido.Escribir("Datos multimedia - privados");

        }
    }
}
