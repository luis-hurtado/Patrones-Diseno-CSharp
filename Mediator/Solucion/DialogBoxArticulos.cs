using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Solucion
{
    public class DialogBoxArticulos : DialogBox
    {
        public ListBox articulosListBox;
        public TextBox tituloTextBox;
        public Button guardarButton;

        public DialogBoxArticulos()
        {
            this.articulosListBox = new ListBox(this);
            this.tituloTextBox = new TextBox(this);
            this.guardarButton = new Button(this);
        }

        public void SimularInteraccionUsuario()
        {
            articulosListBox.ItemSeleccionado = "Articulo 1";
            Console.WriteLine($"TextBox: {tituloTextBox.Texto}");
            Console.WriteLine($"Button: {guardarButton.Habilitado}");

            tituloTextBox.Texto = "";
            Console.WriteLine($"TextBox: {tituloTextBox.Texto}");
            Console.WriteLine($"Button: {guardarButton.Habilitado}");

            tituloTextBox.Texto = "Mi nuevo titulo para el articulo";
            Console.WriteLine($"TextBox: {tituloTextBox.Texto}");
            Console.WriteLine($"Button: {guardarButton.Habilitado}");

        }

        public override void AlCambiar(ControlesUI control)
        {
            if(control == articulosListBox)
                ArticuloSeleccionado();
            else if( control == tituloTextBox)
                TituloCambiado();

        }

        private void TituloCambiado()
        {
            var estaVacio = string.IsNullOrWhiteSpace(tituloTextBox.Texto);
            guardarButton.Habilitado = !estaVacio;
        }

        private void ArticuloSeleccionado()
        {
            tituloTextBox.Texto = articulosListBox.ItemSeleccionado;
            guardarButton.Habilitado = true;
        }
    }
}
