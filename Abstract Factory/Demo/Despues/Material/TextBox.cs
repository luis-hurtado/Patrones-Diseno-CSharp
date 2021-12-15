using System;

namespace AbstractFactory.Demo.Despues.Material
{
    internal class TextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
