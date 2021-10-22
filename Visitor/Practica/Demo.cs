using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Practica
{
    public class Demo
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n\nPRACTICA PATRON VISITOR\n");
            ImpuestoGeneral impuestos = new ImpuestoGeneral();
            ImpuestoFeriados impuestosFeriado = new ImpuestoFeriados();

            PrimeraNecesidad leche = new PrimeraNecesidad(8.50);
            Licor vodka = new Licor(120.0);
            Tabaco marlboro = new Tabaco(19.50);

            Console.WriteLine("\nAPLICAMOS IMPUESTOS GENERALES\n");
            Console.WriteLine(leche.Aplicar(impuestos));
            Console.WriteLine(vodka.Aplicar(impuestos));
            Console.WriteLine(marlboro.Aplicar(impuestos));

            Console.WriteLine("\nAPLICAMOS IMPUESTOS FERIADO\n");
            Console.WriteLine(leche.Aplicar(impuestosFeriado));
            Console.WriteLine(vodka.Aplicar(impuestosFeriado));
            Console.WriteLine(marlboro.Aplicar(impuestosFeriado));

        }
    }
}
