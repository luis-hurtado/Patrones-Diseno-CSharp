using System.Collections.Generic;

namespace Factory_Method.Pizzeria
{
    internal class Test
    {
        public static void Ejecutar()
        {
            new CocineroConHornoALaPiedra().Preparar("Hawaiana", new List<string>() { "hamon", "piña", "cherry" });
            new CocineroConSarten().Preparar("Chorizona", new List<string>() { "Chorizo español", "pimiento morron" });
            new CocineroConHorno().Preparar("Vegetariana", new List<string>() { "brocoly", "Coliflor", "Zanahoria" });
        }
    }



}
