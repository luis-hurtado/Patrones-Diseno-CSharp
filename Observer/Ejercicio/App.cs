using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Ejercicio
{
    public class App
    {
        public static void Ejecutar()
        {
            // Sujeto observable
            BolsaValores bolsa = new BolsaValores();

            // Observadores
            CorredorBolsa jose = new CorredorBolsa("Jose",bolsa);
            CorredorBolsa mario = new CorredorBolsa("Mario", bolsa);
            CorredorBolsa luis = new CorredorBolsa("Luis", bolsa);

            // Agregar nuestros observadores
            bolsa.AgregarObservador(jose);
            bolsa.AgregarObservador(mario);
            bolsa.AgregarObservador(luis);

            // Actualice el estado del sujeto observable
            Console.WriteLine("\nPRIMERA CORRIDA\n");
            bolsa.Datos = new Resultados(197.00, 677.60, 676.40);

            // Eliminar algun observador
            bolsa.EliminarObservador(luis);

            // Actualizamos nuevamente el estado del sujeto observable
            Console.WriteLine("\nSEGUNDA CORRIDA\n");
            bolsa.Datos = new Resultados(191.00, 671.60, 671.40);
            luis.Reporte();

            // Eliminar algun observador
            bolsa.EliminarObservador(jose);

            // Actualizamos nuevamente el estado del sujeto observable
            Console.WriteLine("\nTERCERA CORRIDA\n");
            bolsa.Datos = new Resultados(201.00, 535.60, 620.40);
            jose.Reporte();
            luis.Reporte();

        }
    }
}
