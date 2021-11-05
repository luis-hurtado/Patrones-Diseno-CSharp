using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Despues
{
    public class LGTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine($"LG: set channel {number} ");
        }

        public void TurnOff()
        {
            Console.WriteLine("LG: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("LG: Turn On");
        }
    }
}
