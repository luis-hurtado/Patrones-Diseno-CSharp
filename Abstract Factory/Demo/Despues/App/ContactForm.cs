﻿namespace AbstractFactory.Demo.Despues.App
{
    internal class ContactForm
    {
        public void Render(IWidgetFactory factory)
        {
                factory.CreateTextBox().Render();
                factory.CreateButton().Render();
        }
    }
}
