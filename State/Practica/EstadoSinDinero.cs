using System;

namespace State.Practica
{
    internal class EstadoSinDinero : IEstadoATM
    {
        private readonly CajeroAtm cajero;

        public EstadoSinDinero(CajeroAtm atmMachine)
        {
            this.cajero = atmMachine;
        }

        public void DevuelveTarjeta()
        {
            Console.WriteLine("No hay saldo, usted no introdujo su tarjeta.");
        }

        public void InsertaTarjeta()
        {
            Console.WriteLine("No hay saldo.");
        }

        public void IntroducePin(int pinIngresado)
        {
            Console.WriteLine("No hay saldo.");
        }

        public void SolicitaDinero(int cashToWithdraw)
        {
            Console.WriteLine("No hay saldo.");
        }
    }
}