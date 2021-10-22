namespace Strategy.Despues
{
    public class Demo
    {
        public static void Ejecutar()
        {
            // Formatos de compresion -> jpeg, png....
            var compresorSeleccionado = new CompresorJpeg();
            // Tipos de filtros de imagen -> B&N(Blanco y negro), Alto Contraste, Sepia, etc...
            var filtroSeleccionado = new FiltroSepia();

            // Tenemos nuestro almacen de imagenes en el que guardamos nuestra imagen segun el formato de compresion y filtro seleccionados
            AlmacenImagenes almacen = new AlmacenImagenes(compresor: compresorSeleccionado, filtro: filtroSeleccionado);
            almacen.Guardar(imagenSeleccionada: "c://fotos/foto001.abc");
        }
    }
}
