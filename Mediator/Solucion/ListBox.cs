using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Solucion
{
    public class ListBox : ControlesUI
    {
        private string itemSeleccionado;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string ItemSeleccionado
        {
            get => itemSeleccionado;
            set
            {
                itemSeleccionado = value;
                owner.AlCambiar(this);
            }
        }
    }
}
