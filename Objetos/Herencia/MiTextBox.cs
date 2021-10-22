using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Herencia
{
    public class MiTextBox:UIControl
    {
        public void Disable()
        {
            Console.WriteLine("Disable");
        }

        public override string ToString()
        {
            return "Saludos desde ToString()";
        }
    }
}
