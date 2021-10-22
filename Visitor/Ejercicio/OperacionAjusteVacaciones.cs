using System;

namespace Visitor.Ejercicio
{
    /// <summary>
    /// Clase del tipo 'ConcreteVisitor'
    /// </summary>
    public class OperacionAjusteVacaciones : IVisitor
    {
        public OperacionAjusteVacaciones(int diasVacacion)
        {
            this.DiasVacacion = diasVacacion;
        }

        public int DiasVacacion { get; set; } = 0;

        public void Visitar(IElemento elemento)
        {
            Empleado empleado = elemento as Empleado;

            // Incremento de 3 dias de vacaion
            empleado.DiasVacacion += DiasVacacion;
            Console.WriteLine($"{empleado.GetType().Name}\t{empleado.Nombre}\tDias de vacacion: {empleado.DiasVacacion}");
        }
    }
}
