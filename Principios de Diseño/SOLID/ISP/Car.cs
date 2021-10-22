using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Car : IVehicle
    {
        public void TurnLeft()
        {
            Console.WriteLine("Girando a la izquierda");

        }

        public void TurnRight()
        {
            Console.WriteLine("Girando a la derecha");

        }

        public void GoBackwards()
        {
            Console.WriteLine("Retrocediendo");

        }

        public void GoForward()
        {
            Console.WriteLine("Avanzando");
        }

        public void Land()
        {
            throw new NotSupportedException("Los coches no aterrizan");
        }

        public void TakeOff()
        {
            throw new NotSupportedException("Los coches no despegan");
        }
    }
}
