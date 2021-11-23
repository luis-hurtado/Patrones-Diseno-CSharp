using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Despues
{
    internal class CloudStreamEncriptado : IStream
    {
        private IStream stream;

        public CloudStreamEncriptado(IStream stream)
        {
            this.stream = stream;
        }

        public void Escribir(string data)
        {
            var dataEncriptada = Encriptar(data);
            stream.Escribir(dataEncriptada);
        }

        private string Encriptar(string data)
        {
            return "!sdasa··&()sdfsfre###ffdASDASDASDA asdSADas dsa DSAd SAD saD AS.".Substring(0, data.Length - 1);
        }
    }
}

