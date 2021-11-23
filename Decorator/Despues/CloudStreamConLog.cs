using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Despues
{
    internal class CloudStreamConLog : IStream
    {
        private IStream stream;

        public CloudStreamConLog(IStream stream)
        {
            this.stream = stream;
        }

        public void Escribir(string data)
        {
            GuardarLog(data);
            stream.Escribir(data);
        }

        private void GuardarLog(string data)
        {
            Console.WriteLine("Escribiendo en el log DATA = " + data);
        }

        
    }
}
