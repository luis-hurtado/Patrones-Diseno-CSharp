using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Antes
{
    
    public class SonyAdvanceRemoteControl : AdvancedRemoteControl
    {
        public override void SetChannel(int number)
        {
            Console.WriteLine($"Sony: set channel {number} ");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
    }
}
