using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DemoPull
{
    public class App
    {
        public static void Ejecutar()
        {
            // Sujeto observable
            DatoOrigen ventas = new DatoOrigen();

            // Observadores
            HojaTotales totales1 = new HojaTotales(ventas);
            HojaTotales totales2 = new HojaTotales(ventas);
            Grafico pieChart = new Grafico(ventas);

            // Agregar nuestros observadores
            ventas.AgregarObservador(totales1);
            ventas.AgregarObservador(totales2);
            ventas.AgregarObservador(pieChart);

            // Actualice el estado del sujeto observable
            ventas.Dato = 100;

            // Eliminar alguin observador
            ventas.EliminarObservador(totales2);

            // Actualizamos nuevamente el estado del sujeto observable
            ventas.Dato = 200;

        }
    }
}
