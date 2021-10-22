namespace Visitor.Practica
{
    public class PrimeraNecesidad : IElemento
    {
        private readonly double precio;

        public PrimeraNecesidad(double precio)
        {
            System.Console.WriteLine("Producto de primera necesidad añadido, Precio:" + precio);
            this.precio = precio;
        }

        public double Precio => precio;


        public double Aplicar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
