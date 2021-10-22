using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Practica
{
    /// <summary>
    /// Ejemplo Cajero
    /// 
    /// Pensemos en los posibles estados y acciones de un cajero
    /// Acciones:
    ///     - InsertaTarjeta
    ///     - DevuelveTarjeta
    ///     - IntroducePin
    ///     - SolicitaDinero
    /// Estados: 
    ///     - TarjetaIntroducida
    ///     - SinTarjeta
    ///     - PinIntroducido
    ///     - SinDinero
    /// </summary>
    public class Demo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Practica Patron State - Ejeccio del Cajero!");

            CajeroAtm cajeroATM = new CajeroAtm();

            cajeroATM.InsertaTarjeta();
            cajeroATM.DevuelveTarjeta();

            cajeroATM.InsertaTarjeta();
            cajeroATM.IntroducePin(1234);
            cajeroATM.SolicitaDinero(1000);

            cajeroATM.InsertaTarjeta();
            cajeroATM.IntroducePin(2222);

            cajeroATM.DevuelveTarjeta();

            Console.ReadKey();
        }
    }
}
