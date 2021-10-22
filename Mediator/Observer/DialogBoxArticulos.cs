using System;

namespace Mediator.Observer
{
    public class DialogBoxArticulos
    {
        public ListBox articlesListBox = new ListBox();
        public TextBox titleTextBox = new TextBox();
        public Button saveButton = new Button();

        public DialogBoxArticulos()
        {
            articlesListBox.AgregarEvento(ArticlesSelected);
            titleTextBox.AgregarEvento(TitleChanged);
        }

        public void SimularInteraccionUsuario()
        {
            articlesListBox.ITemSeleccionado = "Articulo 1";
            Console.WriteLine($"TextBox: {titleTextBox.Texto}");
            Console.WriteLine($"Button: {saveButton.Habilitado}");
            titleTextBox.Texto = "";
            Console.WriteLine($"TextBox: {titleTextBox.Texto}");
            Console.WriteLine($"Button: {saveButton.Habilitado}");
            titleTextBox.Texto = "Nuevo Titulo Articulo";
            Console.WriteLine($"TextBox: {titleTextBox.Texto}");
            Console.WriteLine($"Button: {saveButton.Habilitado}");
        }

        private void TitleChanged()
        {
            var texto = titleTextBox.Texto;
            var isEmpty = string.IsNullOrWhiteSpace(texto);
            saveButton.Habilitado = !isEmpty;
        }

        private void ArticlesSelected()
        {
            titleTextBox.Texto = articlesListBox.ITemSeleccionado;
            saveButton.Habilitado = true;
        }
    }
}
