namespace Iterator.Despues
{
    public partial class BrowseHistoryArray : IAgregado
    {
        private readonly string[] urls = new string[10];
        internal int count;
        public void Push(string url)
        {
            urls[count++] = url;            
        }

        public string Pop()
        {            
            return urls[--count];
        }

        public IIterador CrearIterador()
        {
            return new IteradorArreglos(this);
        }
    }
}
