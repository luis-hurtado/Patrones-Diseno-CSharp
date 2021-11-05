using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Despues
{
    public class Demo
    {
        public static void Ejecutar()
        {
            IDevice Sony = new SonyTV();
            RemoteControl remote = new RemoteControl(Sony);
            remote.TurnOn();
            remote.TurnOff();

            //IDevice Samsung = new SamsungTV();
            IDevice LG = new LGTV();
            AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(LG);
            advancedRemote.TurnOn();
            advancedRemote.TurnOff();
            advancedRemote.SetChannel(30);

        }
    }
}
