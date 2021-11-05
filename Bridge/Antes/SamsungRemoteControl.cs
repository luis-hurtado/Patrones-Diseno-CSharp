using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Antes
{
    public class SamsungRemoteControl : RemoteControl
    {
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
