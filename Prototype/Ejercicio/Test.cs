using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype.Ejercicio
{
    internal class Test
    {
        public static void Ejecutar()
        {
            //Creamos una tienda
            var tiendaAmiga = new Tienda();
            //Creamos una lista de dispositivos en venta
            var dispositivosVendidos = new List<Dispositivo>();

            //Llenamos la lista de productos para la tienda
            tiendaAmiga["iPhone"] = new Dispositivo
            {
                Guid = Guid.Empty,
                Marca = "iPhone",
                Modelo = "X13",
                Precio = 1000
            };
            tiendaAmiga["iPad"] = new Dispositivo
            {
                Guid = Guid.Empty,
                Marca = "iPad",
                Modelo = "A2342",
                Precio = 1200
            };

            //Simulamos el proceso de e-commerce
            var iPhoneParaDavid = tiendaAmiga["iPhone"].Clonar() as Dispositivo;
            iPhoneParaDavid.Guid = Guid.NewGuid();
            iPhoneParaDavid.Duenio = "David";
            dispositivosVendidos.Add(iPhoneParaDavid);

            var iPhoneParaMigdo = tiendaAmiga["iPhone"].Clonar() as Dispositivo;
            iPhoneParaMigdo.Guid = Guid.NewGuid();
            iPhoneParaMigdo.Duenio = "Migdo";
            dispositivosVendidos.Add(iPhoneParaMigdo);

            var iPadParaAndres = tiendaAmiga["iPad"].Clonar() as Dispositivo;
            iPadParaAndres.Guid = Guid.NewGuid();
            iPadParaAndres.Duenio = "Sara";
            dispositivosVendidos.Add(iPadParaAndres);

            //Imprimimos el cierre de caja al final del dia
            Console.WriteLine("\n\n\nMostramos todos los iPhones vendidos");
            Console.WriteLine("--------- ----- --- ------- --------");
            var iPhones = dispositivosVendidos.Where(d => d.Marca == "iPhone");
            foreach (var iPhone in iPhones)
            {
                Console.Write(iPhone);
            }
        }
    }
}
