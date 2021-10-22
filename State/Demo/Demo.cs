namespace State.Demo
{
    public class Demo
    {
        public static void Ejecutar()
        {
            Lienzo lienzo = new Lienzo();
            IHerramienta herramienta = new HerramientaSeleccion();
            lienzo.TipoHerramientaActual = herramienta;
            lienzo.MouseDown();
            // arrastro 
            lienzo.MouseUp();

            herramienta = new HerramientaPincel();
            lienzo.TipoHerramientaActual = herramienta;
            lienzo.MouseDown();
            // arrastro 
            lienzo.MouseUp();

            herramienta = new HerramientaBorrador();
            lienzo.TipoHerramientaActual = herramienta;
            lienzo.MouseDown();
            // arrastro 
            lienzo.MouseUp();
        }
    }
}
