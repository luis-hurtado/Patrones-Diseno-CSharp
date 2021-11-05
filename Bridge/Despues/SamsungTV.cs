using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Despues
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine($"Samsung: set channel {number} ");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: Turn On");
        }
    }
}
