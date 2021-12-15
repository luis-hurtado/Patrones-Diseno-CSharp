using System;

namespace AbstractFactory.Demo.Antes.Material
{
    internal class TextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
