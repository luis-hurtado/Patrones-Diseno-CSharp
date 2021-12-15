namespace AbstractFactory.Demo.Despues.Ant
{
    internal class AntWidgetFactory : IWidgetFactory
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
