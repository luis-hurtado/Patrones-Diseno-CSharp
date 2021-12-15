using System;

namespace AbstractFactory.Demo.Despues.Material
{
    internal class Button : IButton
    {
        public void Render()
        {
            Console.WriteLine("Material Button");
        }
    }
}
