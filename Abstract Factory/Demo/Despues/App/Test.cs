using System;

namespace AbstractFactory.Demo.Despues.App
{
    internal class Test
    {
        public static void Ejecutar() {
            var formulario = new ContactForm();

            Console.WriteLine("UTILIZAMOS EL TEMA ANT");
            IWidgetFactory ant = new Ant.AntWidgetFactory();
            formulario.Render(ant);

            Console.WriteLine("\nUTILIZAMOS EL TEMA MATERIAL");
            formulario.Render(new Material.MaterialWidgetFactory());
        }
    }
}
