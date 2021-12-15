namespace AbstractFactory.Demo.Despues.Material
{
    internal class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new Button();
        }

        public ITextBox CreateTextBox()
        {
            return new TextBox();
        }
    }
}
