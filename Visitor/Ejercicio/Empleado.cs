namespace Visitor.Ejercicio
{
    /// <summary>
    /// La Clase 'ConcreteElement'
    /// </summary>
    public class Empleado : IElemento
    {
        // Constructor
        public Empleado(string nombre, double salario, int diasVacacion)
        {
            Nombre = nombre;
            Salario = salario;
            DiasVacacion = diasVacacion;
            MostrarEmpleado();
        }

        public string Nombre { get; set; }

        public double Salario { get; set; }

        public int DiasVacacion { get; set; }

        public void MostrarEmpleado()
        {
            System.Console.WriteLine(
                "Nombre: " + Nombre + 
                "\tSalario: " + Salario +
                "\tDias Vacacion" + DiasVacacion);
        }

        public void Aplicar(IVisitor operacion)
        {
            operacion.Visitar(this);
        }
    }
}
