namespace Objetos.Herencia
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var textBox = new MiTextBox();
            textBox.Enable();
            textBox.Disable();
            System.Console.WriteLine( textBox.ToString());
        }
    }
}
