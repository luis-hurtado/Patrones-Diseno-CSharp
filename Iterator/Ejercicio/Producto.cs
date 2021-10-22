namespace Iterator.Ejercicio
{
    internal class Producto
    {
        private int id;
        private string descripcion;
        private int cantidad;
        private double precio;

        public Producto(int id, string descripcion, int cantidad, double precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public override string ToString()
        {
            return "Producto{ " +
                "id=" + id + ", " +
                "nombre='" + descripcion + "', " +
                "cantidad=" + cantidad + ", " +
                "precio=" + precio +
                " }";
        }
    }
}