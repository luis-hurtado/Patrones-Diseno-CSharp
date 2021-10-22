namespace Visitor.Ejercicio
{
    // tres tipos de empleados
    public class Oficinista : Empleado
    {
        // Constructor
        public Oficinista() : base("Pepito", 25000.0, 14){}
    }

    public class Director : Empleado
    {
        // Constructor
        public Director() : base("Juanito", 35000.0, 16) {}
    }

    public class Presidente : Empleado
    {
        // Constructor
        public Presidente() : base("Yolita", 45000.0, 21) { }
    }
}
