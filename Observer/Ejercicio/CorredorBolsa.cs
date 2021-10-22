using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Ejercicio
{
    internal class CorredorBolsa: IObservador
    {
        int id;
        static int secuencia = 0;
        string nombre;
        Resultados resultados;

        BolsaValores bolsaValores;

        public CorredorBolsa(string nombre, BolsaValores bolsa)
        {
            this.id = ++secuencia;
            this.nombre = nombre;
            this.bolsaValores = bolsa;
            Console.WriteLine( $"Nuevo corredor de bolsa id:{this.id} nombre:{this.nombre}");
        }

        public void Actualizar()
        {
            resultados = bolsaValores.Datos;            
            Reporte();
        }

        public void Reporte()
        {
            Console.WriteLine(
                $"Resultados para el corredorid:{this.id} nombre:{this.nombre}" +
                "\n\tIBM:" + resultados.PrecioIbm +
                "\n\tGoogle:" + resultados.PrecioGoogle +
                "\n\tMicrosoft:" + resultados.PrecioMicrosoft +
                "\n");
        }
    }
}
