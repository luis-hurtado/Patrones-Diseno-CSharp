namespace Proxy.Demo.Despues
{
    internal class App
    {
        public static void Ejecutar()
        {
            var libreriaDigital = new Biblioteca();
            string[] archivos = { "libro 1.pdf", "libro 2.pdf", "libro 3.pdf", "libro 4.pdf", "libro 5.pdf" };
            System.Console.WriteLine("LISTADO DE LIBROS");
            foreach (var archivo in archivos)
            {
                System.Console.WriteLine("\t" + archivo);
                IEBook libro = new EBookLoggingProxy(archivo);
                libreriaDigital.Agregar(libro);
            }

            System.Console.WriteLine("Usuario hizo Doble Click en libro 3");
            libreriaDigital.AbrirLibro("libro 3.pdf");
            System.Console.WriteLine();
            System.Console.WriteLine("Usuario hizo Doble Click en libro 4");
            libreriaDigital.AbrirLibro("libro 4.pdf");
            System.Console.WriteLine();
            System.Console.WriteLine("Usuario hizo Doble Click en libro 3");
            libreriaDigital.AbrirLibro("libro 3.pdf");

        }
    }
}
