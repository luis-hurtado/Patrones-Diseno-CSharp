﻿namespace Bridge.Despues
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device){ }

        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }
}
