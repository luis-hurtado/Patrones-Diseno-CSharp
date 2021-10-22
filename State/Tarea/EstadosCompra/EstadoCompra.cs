using static State.Tarea.Compra;

namespace State.Tarea.EstadosCompra
{
    internal abstract class EstadoCompra : IEstadoCompra
    {
        public Compra Compra { get; }

        public EstadoCompra(Compra compra) => this.Compra = compra;

        public virtual void Comprar(decimal precio, FormasPago formaPago, FormasEnvio formaEnvio)
        {
            System.Console.WriteLine("No se puede realizar una compra mientras se encuentra en el estado " + Compra.EstadoActual.ToString());
        }

        public virtual void Verificar()
        {
            System.Console.WriteLine("No se puede verificar una compra mientras se encuentra en el estado " + Compra.EstadoActual.ToString());
        }

        public virtual void Enviar()
        {
            System.Console.WriteLine("No se puede enviar una compra mientras se encuentra en el estado " + Compra.EstadoActual.ToString());
        }

        public virtual void Cancelar()
        {
            System.Console.WriteLine("No se puede cancelar una compra mientras se encuentra en el estado " + Compra.EstadoActual.ToString());
        }

    }
}
