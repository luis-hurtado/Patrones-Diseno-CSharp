namespace Objetos.Agregacion
{
    public class Pedido
    {
        private int _items;

        public void AgregarItem()
        {
            _items += 1;
        }

        public int RevisarItems()
        {
            return _items;
        }
    }
}
