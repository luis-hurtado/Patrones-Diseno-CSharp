using System;

namespace Decorator.Despues
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Datos normales");
            IStream stream = new CloudStream();
            stream.Escribir("Datos normales");

            Console.WriteLine();
            Console.WriteLine("Datos confidenciales");
            IStream streamEncriptado =  new CloudStreamEncriptado(new CloudStream());
            streamEncriptado.Escribir("Datos confidenciales");


            Console.WriteLine();
            Console.WriteLine("Datos multimedia");
            IStream streamComprimido = new CloudStreamComprimido(new CloudStream());
            streamComprimido.Escribir("Datos multimedia");


            Console.WriteLine();
            Console.WriteLine("Datos multimedia - confidenciales");
            IStream streamComprimidoYEncriptado = new CloudStreamEncriptado(new CloudStreamComprimido(new CloudStream()));
            streamComprimidoYEncriptado.Escribir("Datos multimedia - confidenciales");


            Console.WriteLine();
            Console.WriteLine("Datos multimedia - confidenciales2");
            IStream streamComprimidoYEncriptado2 = new CloudStreamComprimido(new CloudStreamEncriptado(new CloudStream()));
            streamComprimidoYEncriptado2.Escribir("2Datos multimedia - confidenciales");


            Console.WriteLine();
            Console.WriteLine("Datos normales + log");
            IStream streamConLog = new CloudStreamConLog(new CloudStream());
            streamConLog.Escribir("Datos normales + log");


            Console.WriteLine();
            Console.WriteLine("Datos normales + log + Encriptacion");
            IStream streamConLog2 = new CloudStreamConLog(new CloudStreamEncriptado(new CloudStream()));
            streamConLog2.Escribir("Datos normales + log + Encriptacion");

            Console.WriteLine();
            Console.WriteLine("Datos normales + Encriptacion + log");
            IStream streamConLog3 = new CloudStreamEncriptado(new CloudStreamConLog(new CloudStream()));
            streamConLog3.Escribir("Datos normales + Encriptacion + log");
        }
    }
}
