using System;

namespace AbstractFactory.Demo.Despues.Ant
{
    internal class Button : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}
