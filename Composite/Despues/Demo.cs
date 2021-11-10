namespace Composite.Despues
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var grupo1 = new Grupo();

            var cuadrado1 = new Figura();

            grupo1.AgregarElemento(cuadrado1); // Cuadrado 1
            grupo1.AgregarElemento(new Figura()); // Cuadrado 2

            var grupo2 = new Grupo();
            grupo2.AgregarElemento(new Figura()); // Circulo 1
            grupo2.AgregarElemento(new Figura()); // Circulo 2

            var grupoRaiz = new Grupo();
            grupoRaiz.AgregarElemento(grupo1);
            grupoRaiz.AgregarElemento(grupo2);

            //grupoRaiz.Dibujar();
            //grupoRaiz.Mover();
            //grupo1.Dibujar();
            //grupo1.Mover();
            cuadrado1.Dibujar();
            cuadrado1.Mover();

        }
    }
}
