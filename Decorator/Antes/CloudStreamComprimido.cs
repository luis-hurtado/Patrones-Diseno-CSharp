using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Antes
{
    internal class CloudStreamComprimido : CloudStream
    {
        public override void Escribir(string data)
        {
            var dataComprimida = Comprimir(data);
            base.Escribir(dataComprimida);
        }

        private string Comprimir(string data)
        {
            return data.Substring(0,5);
        }
    }
}
