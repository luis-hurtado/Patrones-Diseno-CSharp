namespace State.Practica
{
    internal class CajeroAtm
    {
        IEstadoATM estadoActual;

        private int dineroDisponible = 2000;
        public bool pinIntroducidoValido = false;

        public CajeroAtm()
        {
            TarjetaIntroducida = new EstadoTarjetaIntroducida(this);
            SinTarjeta = new EstadoSinTarjeta(this);
            PinIntroducido = new EstadoPinIntroducido(this);
            SinDinero = new EstadoSinDinero(this);

            estadoActual = SinTarjeta;

            if (DineroDisponible < 0)
            {
                estadoActual = SinDinero;
            }
        }

        internal IEstadoATM TarjetaIntroducida { get; }
        internal IEstadoATM SinTarjeta { get; }
        internal IEstadoATM PinIntroducido { get; }
        internal IEstadoATM SinDinero { get; }


        internal int DineroDisponible { get => dineroDisponible; set => dineroDisponible = value; }
        internal IEstadoATM EstadoCajero { get => estadoActual; set => estadoActual = value; }



        internal void RetiraDineroDelCajero(int newCashInMachine)
        {
            this.DineroDisponible -= newCashInMachine;
        }
        


        public void InsertaTarjeta()
        {
            estadoActual.InsertaTarjeta();
        }
        public void DevuelveTarjeta()
        {
            estadoActual.DevuelveTarjeta();
        }
        public void SolicitaDinero(int cashToWithdraw)
        {
            estadoActual.SolicitaDinero(cashToWithdraw);
        }
        public void IntroducePin(int pinIngresado)
        {
            estadoActual.IntroducePin(pinIngresado);
        }

    }
}


