using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Antes
{
    public class Demo
    {
        public static void Ejecutar()
        {
            //Controles Remotos:
            //  - Basico 
            //      - TV Sony
            //      - TV Samsung
            //  - Avanzado
            //      - TV Sony
            //      - TV Samsung
            RemoteControl remote = new SamsungRemoteControl();
            remote.TurnOn();
            remote.TurnOff();

            AdvancedRemoteControl advancedRemote = new SonyAdvanceRemoteControl();
            advancedRemote.TurnOn();
            advancedRemote.TurnOff();
            advancedRemote.SetChannel(30);

        }
    }
}
