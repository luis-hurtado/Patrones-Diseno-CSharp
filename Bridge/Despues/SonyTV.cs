using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Despues
{
    public class SonyTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine($"Sony: set channel {number} ");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
    }
}
