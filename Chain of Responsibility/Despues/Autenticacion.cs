using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Despues
{
    public class Autenticacion : Manejador
    {
        public Autenticacion(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("AUTENTICACION");
            bool esValido = (request.Usuario == "Admin" && request.Password == "1234");
            if (esValido)
                Console.WriteLine("El usuario es valido");
            else
                Console.WriteLine("Usuario invalido");

            return !esValido;
        }
    }
}
