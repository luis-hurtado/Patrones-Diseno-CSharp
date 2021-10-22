namespace Iterator.Ejercicio
{
    internal interface IIterador
    {
        bool TieneSiguiente { get; }

        Producto Actual();
        void Siguiente();
    }
}