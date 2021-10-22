namespace Strategy.Tarea.Antivirus
{
    public abstract class AnalisisSimple : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            SaltarZip();
            Detener();
        }

        internal abstract void Iniciar();

        internal abstract void SaltarZip();

        internal abstract void Detener();
    }
}
