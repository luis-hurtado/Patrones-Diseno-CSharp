using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Despues
{
    internal class CloudStreamComprimido : IStream
    {
        private IStream stream;

        public CloudStreamComprimido(IStream stream)
        {
            this.stream = stream;
        }

        public void Escribir(string data)
        {
            var dataComprimida = Comprimir(data);
            stream.Escribir(dataComprimida);
        }

        private string Comprimir(string data)
        {
            return data.Substring(0,5);
        }
    }
}
