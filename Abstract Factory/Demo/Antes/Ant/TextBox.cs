using System;

namespace AbstractFactory.Demo.Antes.Ant
{
    internal class TextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant TextBox");
        }
    }
}
