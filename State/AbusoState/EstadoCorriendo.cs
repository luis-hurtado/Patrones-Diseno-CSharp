using System;

namespace State.AbusoState
{
    public class EstadoCorriendo : IEstado
    {
        private Cronometro cronometro;

        public EstadoCorriendo(Cronometro cronometro)
        {
            this.cronometro = cronometro;
        }
        public void Click()
        {
            cronometro.EstadoActual = new EstadoDetenido(cronometro);
            Console.WriteLine("El cronometro se ha detenido...");
        }
    }
}
