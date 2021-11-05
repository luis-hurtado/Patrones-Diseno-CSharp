namespace Bridge.Despues
{
    public class RemoteControl
    {
        protected readonly IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }

        public void TurnOff()
        {
            device.TurnOff();
        }

    }
}
