using System;

namespace AbstractFactory.Demo.Antes.App
{
    internal class Test
    {
        public static void Ejecutar() {
            var formulario = new ContactForm();
            Console.WriteLine("UTILIZAMOS EL TEMA ANT");
            formulario.Render(Theme.ANT);

            Console.WriteLine("\nUTILIZAMOS EL TEMA MATERIAL");
            formulario.Render(Theme.MATERIAL);
        }
    }
}
