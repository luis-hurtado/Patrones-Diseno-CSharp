namespace Objetos.Composicion
{
    public class Llanta
    {
        private int _llantas;

        public void AgregarLlanta()
        {
            _llantas += 1;
        }

        public int RevisarLlantas()
        {
            return _llantas;
        }
    }
}
