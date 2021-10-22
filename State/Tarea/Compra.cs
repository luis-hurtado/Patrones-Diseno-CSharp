using State.Tarea.EstadosCompra;
using System;

namespace State.Tarea
{
    public partial class Compra
    {
        internal EstadoCompra EstadoActual { get; set; }

        internal FormasEnvio FormaEnvio { get; set; }

        internal FormasPago FormaPago { get; set; }

        internal decimal Precio { get; set; }

        public Compra()
        {   
            Console.WriteLine();
            Console.WriteLine("Se ha creado la orden");
            InicializarEstados();
            EstadoActual = creada;
        }

        

        public void Comprar(decimal precio, FormasPago formaPago, FormasEnvio formaEnvio)
        {
            EstadoActual.Comprar(precio, formaPago, formaEnvio);
        }
        public void Verificar()
        {
            EstadoActual.Verificar();
        }

        public void Enviar()
        {
            EstadoActual.Enviar();
        }

        public void Cancelar()
        {
            EstadoActual.Cancelar();
        }

    }
}
