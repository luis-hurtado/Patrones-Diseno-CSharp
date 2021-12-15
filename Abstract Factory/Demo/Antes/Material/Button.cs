using System;

namespace AbstractFactory.Demo.Antes.Material
{
    internal class Button : IButton
    {
        public void Render()
        {
            Console.WriteLine("Material Button");
        }
    }
}
