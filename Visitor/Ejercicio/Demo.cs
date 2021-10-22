using System;

namespace Visitor.Ejercicio
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    public class Demo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n\nEJERCICIO PATRON VISITOR\n");
            // Cargamos nuestra planilla de empleados
            PlanillaEmpleados planilla = new PlanillaEmpleados();
            planilla.Contratar(new Oficinista());
            planilla.Contratar(new Director());
            planilla.Contratar(new Presidente());

            // Ejecutamos las operaciones
            Console.WriteLine("\nIncremento salarial del 10%");
            planilla.Ejecutar(new OperacionIncrementoSalarial(10));
            Console.WriteLine("\nAjuste Vacaciones +3 dias");
            planilla.Ejecutar(new OperacionAjusteVacaciones(3));
        }
    }

    
}
