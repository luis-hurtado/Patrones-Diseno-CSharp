using System.Collections.Generic;

namespace Iterator.Despues
{
    public partial class BrowseHistory : IAgregado
    {
        private readonly List<string> urls = new List<string>();
        
        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var indice = urls.Count - 1;
            var url = urls[indice];
            urls.Remove(url);
            return url;
        }

        public IIterador CrearIterador()
        {
            return new IteradorListas(this);
        }
    }
}
