namespace Mediator.Solucion
{
    public class TextBox : ControlesUI
    {
        private string texto;

        public TextBox(DialogBox owner) : base(owner) { }

        public string Texto { 
            get => texto;
            set
            {
                texto = value;
                owner.AlCambiar(this);
            }
        }
    }
}
