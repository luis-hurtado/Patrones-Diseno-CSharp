using System;

namespace Visitor.Ejercicio
{
    /// <summary>
    /// Clase del tipo 'ConcreteVisitor'
    /// </summary>
    public class OperacionIncrementoSalarial : IVisitor
    {
        public int Incremento { get; set; } = 0;

        public OperacionIncrementoSalarial(int incremento)
        {
            Incremento = incremento;
        }

        private double CalcularIncremento(int incremento)
        {
            if (incremento <= 0 || incremento > 100)
            {
                Console.WriteLine("El incremento salarial debe estar entre 1 y 100");
                return 0;
            }

            return 1 + (incremento / 100D);
        }

        public void Visitar(IElemento elemento)
        {
            Empleado empleado = elemento as Empleado;

            // Incremento salarial del 10%
            empleado.Salario *= CalcularIncremento(Incremento);
            Console.WriteLine($"{empleado.GetType().Name}\t{empleado.Nombre}\t Nuevo Salario: {empleado.Salario}");
        }
    }
}
