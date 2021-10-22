using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases_y_Miembros
{
    class EjemploPropiedades
    {
        // Campos
        private decimal precioItem;
        private int cantidad;

        //Propiedades
        // Metodos Getter y Setter - Estilo antiguo como se utiliza Java
        public decimal GetPrecioItem()
        {
            return precioItem;
        }
        public void SetPrecioItem(decimal value)
        {
            precioItem = value;
        }

        // Propiedades Como se utilizan en c#
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        // Propiedades calculadas
        public decimal CostoTotal
        {
            get
            {                
                return cantidad * precioItem;
            }
        }


        // Propiedades Autoimplementadas: se usa cuando los campos son publicos
        public string Descripcion { get; set; }
        protected int Id { get;  }


    }
}
