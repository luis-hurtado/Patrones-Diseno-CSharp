using System;

namespace Strategy.Despues
{
    public class FiltroSepia : IFiltro
    {
        static string nombreFiltro = "Sepia";
        public void Aplicar()
        {
            Sub1();
        }

        private static void Sub1()
        {
            SubSepia();
        }

        private static void SubSepia()
        {
            Console.WriteLine($"Se aplico el filtro {nombreFiltro} a la imagen");
        }
    }
}
