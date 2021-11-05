using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Antes
{
    public class SamsungAdvanceRemoteControl : AdvancedRemoteControl
    {
        public override void SetChannel(int number)
        {
            Console.WriteLine($"Samsung: set channel {number} ");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Samsung: Turn On");
        }
    }
}
