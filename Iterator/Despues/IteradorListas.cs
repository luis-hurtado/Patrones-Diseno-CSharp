namespace Iterator.Despues
{
    public partial class BrowseHistory
    {
        public class IteradorListas : IIterador
        {
            private readonly BrowseHistory historia;
            private int itemActual;

            public IteradorListas(BrowseHistory historia)
            {
                this.historia = historia;
            }
            public string Actual()
            {
                return historia.urls[itemActual];
            }

            public void Siguiente()
            {
                itemActual++;
            }

            public bool TieneSiguiente()
            {
                return (itemActual < historia.urls.Count);
            }
        }
    }
}
