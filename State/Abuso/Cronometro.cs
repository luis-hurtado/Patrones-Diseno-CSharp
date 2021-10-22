using System;

namespace State.Abuso
{
    public class Cronometro
    {
        private bool estaCorriendo;

        public void Click()
        {
            if (estaCorriendo)
            {
                estaCorriendo = false;
                Console.WriteLine("El cronometro se ha detenido...");
            }
            else
            {
                estaCorriendo = true;
                Console.WriteLine("El cronometro se ha iniciado...");
            }
        }
    }
}
