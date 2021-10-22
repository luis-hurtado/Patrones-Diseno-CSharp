using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Solucion
{
    public class ControlesUI
    {
        protected DialogBox owner;

        public ControlesUI(DialogBox owner)
        {
            this.owner = owner;
        }
    }
}
