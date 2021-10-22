namespace Objetos.Composicion
{
    public class Automovil
    {
        public Llanta llantas = new Llanta();

        public void InstalarLlanta()
        {
            llantas.AgregarLlanta();
        }

        public int RevisarLlantas()
        {
            return llantas.RevisarLlantas();
        }
    }
}
