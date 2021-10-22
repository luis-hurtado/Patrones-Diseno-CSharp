using System;

namespace State.Practica
{
    internal class EstadoSinTarjeta : IEstadoATM
    {
        private readonly CajeroAtm cajero;

        public EstadoSinTarjeta(CajeroAtm atmMachine)
        {
            this.cajero = atmMachine;
        }

        public void DevuelveTarjeta()
        {
            Console.WriteLine("Primero debe Introducir su Tarjeta");
        }

        public void InsertaTarjeta()
        {
            Console.WriteLine("Por favor Inserte Su Pin");
            cajero.EstadoCajero = cajero.TarjetaIntroducida;
        }

        public void IntroducePin(int pinIngresado)
        {
            Console.WriteLine("Primero debe Introducir su Tarjeta");
        }

        public void SolicitaDinero(int cashToWithdraw)
        {
            Console.WriteLine("Primero debe Introducir su Tarjeta");
        }
    }
}