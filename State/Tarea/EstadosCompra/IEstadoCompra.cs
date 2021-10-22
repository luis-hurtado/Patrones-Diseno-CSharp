using static State.Tarea.Compra;

namespace State.Tarea.EstadosCompra
{
    internal interface IEstadoCompra
    {
        void Comprar(decimal precio, FormasPago formaPago, FormasEnvio formaEnvio);
        void Verificar();
        void Enviar();
        void Cancelar();
    }
}
