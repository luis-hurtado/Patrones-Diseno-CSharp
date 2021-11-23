using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Antes
{
    internal class CloudStreamEncriptado : CloudStream
    {
        public override void Escribir(string data)
        {
            var dataEncriptada = Encriptar(data);
            base.Escribir(dataEncriptada);
        }

        private string Encriptar(string data)
        {
            return "!sdasa··&()sdfsfre###ffd.";
        }
    }
}
