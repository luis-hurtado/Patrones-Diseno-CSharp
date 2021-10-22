using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Acoplamiento
{
    public class Demo
    {
        public static void Ejecutar()
        {
            Usuario usuario = new Usuario(nombre: "Luis");
            usuario.Saludar();
        }
    }
}
