namespace Objetos.Agregacion
{
    public class Cliente
    {
        private Pedido _pedido;

        public Cliente()
        {
            _pedido = new Pedido();
        }

        public Cliente(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void SetOrder(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void AgregarIemAlPedido()
        {
            _pedido.AgregarItem();
        }

        public int RevisarItems()
        {
            return _pedido.RevisarItems();
        }
    }
}
