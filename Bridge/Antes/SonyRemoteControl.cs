using System;

namespace Bridge.Antes
{

    public class SonyRemoteControl : RemoteControl
    {
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
