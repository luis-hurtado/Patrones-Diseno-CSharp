using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases_y_Miembros
{
    class EjemploMetodos
    {
        public string Property1 { get; set; }

        // Metodos que no retornan valor -- Procedimientos
        public void Method1() { /*...*/ }

        // Metodos que retornan valor -- Funciones
        public string MethodWithReturn()
        {
            /*...*/
            return "stringValue";
        }
        // Metodos con parametros de entrada
        public string MethodWithParameters(int param1, string param2, decimal param3)
        {
            /*...*/
            return "stringValue";
        }
    }
}
