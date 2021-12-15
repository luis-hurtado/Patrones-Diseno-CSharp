using System;

namespace AbstractFactory.Demo.Antes.Ant
{
    internal class Button : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}
