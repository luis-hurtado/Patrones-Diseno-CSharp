using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            Historial historial = new Historial();


            editor.Contenido = "Hola";
            historial.Push(editor.CrearEstado());

            editor.Contenido = "Hola a todos";
            historial.Push(editor.CrearEstado());
                       
            editor.Contenido = "Un saludo cordial a todos";
            Console.WriteLine(editor.Contenido);

            editor.RestaurarEstado(historial.Pop());
            editor.RestaurarEstado(historial.Pop());
            Console.WriteLine(editor.Contenido);

            Console.ReadLine();
        }
    }
}
