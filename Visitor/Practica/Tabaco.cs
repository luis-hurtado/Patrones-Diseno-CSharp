namespace Visitor.Practica
{
    public class Tabaco : IElemento
    {
        private readonly double precio;

        public Tabaco(double precio)
        {
            System.Console.WriteLine("Producto del tipo tabaco añadido, Precio:" + precio);
            this.precio = precio;
        }

        public double Precio => precio;


        public double Aplicar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
