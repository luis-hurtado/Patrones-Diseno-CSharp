using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases_y_Miembros.EjemploConstructores
{

    public class ClassA
    {
        
    }

    public class ClassB
    {
        public ClassB() { /* Constructor Method */ }
    }

    public class ClassC
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }

        public ClassC(int param1)
        {
            Property2 = param1;
        }

        public ClassC(string param1)
        {
            Property1 = param1;
        }

        public ClassC(string param1, int param2)
        {
            Property1 = param1;
            Property2 = param2;
        }
    }

    //var myClassC = new ClassC("stringValue");
    //var otherClassC = new ClassC("stringValue", 6);

    public class ClassD
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
    }

    //var myClassD = new ClassD();
    public class ClassE
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }

        public ClassE() { /* Public parameterless constructor */
            Property1 = "Hola";
            Property2 = 10;
        }
    }

    //var myClassE = new ClassE();
}
