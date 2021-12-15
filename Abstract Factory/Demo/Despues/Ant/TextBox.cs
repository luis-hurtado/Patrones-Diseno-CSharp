using System;

namespace AbstractFactory.Demo.Despues.Ant
{
    internal class TextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant TextBox");
        }
    }
}
