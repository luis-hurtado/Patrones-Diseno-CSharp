namespace AbstractFactory.Demo.Despues
{
    internal interface IWidgetFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
