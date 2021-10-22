using System;
using System.Collections.Generic;

namespace Visitor.Ejercicio
{    
    public class PlanillaEmpleados
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void Contratar(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void Despedir(Empleado emepleado)
        {
            empleados.Remove(emepleado);
        }

        public void Ejecutar(IVisitor operacion)
        {
            foreach (Empleado empleado in empleados)
            {
                empleado.Aplicar(operacion);
            }
            Console.WriteLine();
        }
    }
}
