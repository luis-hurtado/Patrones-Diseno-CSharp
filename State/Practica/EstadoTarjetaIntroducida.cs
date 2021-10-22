using System;

namespace State.Practica
{
    internal class EstadoTarjetaIntroducida : IEstadoATM
    {
        private readonly CajeroAtm cajero;

        public EstadoTarjetaIntroducida(CajeroAtm atmMachine)
        {
            this.cajero = atmMachine;
        }

        public void DevuelveTarjeta()
        {
            Console.WriteLine("Se devolvio la tarjeta");
            cajero.EstadoCajero = cajero.SinTarjeta;
        }

        public void InsertaTarjeta()
        {
            Console.WriteLine("No puede ingresar mas de una tarjeta.");
        }

        public void IntroducePin(int pinIngresado)
        {
            if (pinIngresado == 1234)
            {
                Console.WriteLine("Pin Correcto");
                cajero.pinIntroducidoValido = true;
                cajero.EstadoCajero = cajero.PinIntroducido;
            }
            else
            {
                Console.WriteLine("Pin Equivocado");
                cajero.pinIntroducidoValido = false;
                Console.WriteLine("Se devolvio la tarjeta");
                cajero.EstadoCajero = cajero.SinTarjeta;
            }
        }

        public void SolicitaDinero(int cashToWithdraw)
        {
            Console.WriteLine("Introduzca Primero su pin");
        }
    }
}