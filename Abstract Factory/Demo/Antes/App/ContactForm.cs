namespace AbstractFactory.Demo.Antes.App
{
    internal class ContactForm
    {
        public void Render(Theme theme)
        {
            if(theme == Theme.ANT)
            {
                new Ant.TextBox().Render();
                new Ant.Button().Render();
            }
            else if(theme == Theme.MATERIAL)
            {
                new Material.TextBox().Render();
                new Material.Button().Render();
            }
        }
    }
}
