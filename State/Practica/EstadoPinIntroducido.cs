using System;

namespace State.Practica
{
    internal class EstadoPinIntroducido : IEstadoATM
    {
        private readonly CajeroAtm cajero;

        public EstadoPinIntroducido(CajeroAtm atmMachine)
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
            Console.WriteLine("No puede Introducir mas de una Tarjeta"); ;
        }

        public void IntroducePin(int pinIngresado)
        {
            Console.WriteLine("Ya inserto su PIN... No necesita hacerlo de nuevo."); ;
        }

        public void SolicitaDinero(int cashToWithdraw)
        {
            if (cashToWithdraw > cajero.DineroDisponible)
            {
                Console.WriteLine("No hay suficiente saldo");
                Console.WriteLine("Se devolvio la tarjeta");
                cajero.EstadoCajero = cajero.SinTarjeta;
            }
            else
            {
                Console.WriteLine($" Se entrego {cashToWithdraw} bolivianos.");
                cajero.RetiraDineroDelCajero(cashToWithdraw);
                Console.WriteLine("Se devolvio la tarjeta");
                cajero.EstadoCajero = cajero.SinTarjeta;

                if (cajero.DineroDisponible <= 0)
                {
                    cajero.EstadoCajero = cajero.SinDinero;
                }
            }
        }
    }
}