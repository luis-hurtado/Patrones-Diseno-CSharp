namespace Iterator.Despues
{
    public partial class BrowseHistoryArray
    {
        public class IteradorArreglos : IIterador
        {
            private readonly BrowseHistoryArray historia;
            private int itemActual;

            public IteradorArreglos(BrowseHistoryArray historia)
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
                return (itemActual < historia.count);
            }
        }
    }
}
