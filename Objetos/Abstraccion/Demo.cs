using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Abstraccion
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var correo = new ServicioCorreo();
            correo.EnviarCorreo("Mensaje");


        }
    }
}
