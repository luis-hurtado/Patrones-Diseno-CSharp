using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Solucion
{
    public class Button : ControlesUI
    {
        private bool habilitado;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool Habilitado
        {
            get => habilitado; 
            set {
                habilitado = value;
                owner.AlCambiar(this);
            }
        }
    }
}
