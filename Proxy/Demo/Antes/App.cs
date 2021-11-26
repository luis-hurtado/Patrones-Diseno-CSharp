namespace Proxy.Demo.Antes
{
    internal class App
    {
        public static void Ejecutar()
        {
            var libreriaDigital = new Biblioteca();
            string[] archivos = { "libro 1.pdf", "libro 2.pdf", "libro 3.pdf", "libro 4.pdf", "libro 5.pdf" };
            foreach (var archivo in archivos)
            {
                libreriaDigital.Agregar(new EBook(archivo));
            }

            libreriaDigital.AbrirLibro("libro 3.pdf");

        }
    }
}
