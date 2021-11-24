namespace Flyweight.Despues
{
    internal class IconosPunto
    {
        readonly private TipoPunto tipo; // 4 bytes
        readonly private sbyte[] icono; // 20 kbytes * 1000 => 20Mb

        public IconosPunto(TipoPunto tipo, sbyte[] icono)
        {
            this.tipo = tipo;
            this.icono = icono;
        }

        internal TipoPunto Tipo { get => tipo; }
    }
}
