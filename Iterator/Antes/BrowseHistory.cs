using System.Collections.Generic;

namespace Iterator.Antes
{
    public class BrowseHistory
    {
        private readonly List<string> urls = new List<string>();
        public List<string> Urls { get => urls; }

        // Ultimos 10 sitios visitados
        //private readonly string[] urls = new string[10];
        //public string[] Urls => urls;

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
    }
}
