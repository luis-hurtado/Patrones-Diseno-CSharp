namespace Strategy.Antes
{
    public class Demo
    {
        public static void Ejecutar()
        {
            // Formatos de compresion -> jpeg, png....
            string compresorSeleccionado = "jpeg";
            // Tipos de filtros de imagen -> B&N(Blanco y negro), Alto Contraste, Sepia, etc...
            string filtroSeleccionado = "B&N";

            // Tenemos nuestro almacen de imagenes en el que guardamos nuestra imagen segun el formato de compresion y filtro seleccionados
            AlmacenImagenes almacen = new AlmacenImagenes(compresor: compresorSeleccionado, filtro: filtroSeleccionado);
            almacen.Guardar(imagenSeleccionada: "c://fotos/foto001.abc");
        }
    }
}
