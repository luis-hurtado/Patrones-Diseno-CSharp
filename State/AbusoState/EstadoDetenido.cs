using System;

namespace State.AbusoState
{
    public class EstadoDetenido : IEstado
    {
        private Cronometro cronometro;

        public EstadoDetenido(Cronometro cronometro)
        {
            this.cronometro = cronometro;
        }

        public void Click()
        {
            cronometro.EstadoActual = new EstadoCorriendo(cronometro);
            ImprimirResultado();
        }

        private static void ImprimirResultado()
        {
            Console.WriteLine("El cronometro se ha iniciado xxx...");
        }
    }
}
