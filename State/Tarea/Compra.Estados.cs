using State.Tarea.EstadosCompra;

namespace State.Tarea
{
    public partial class Compra
    {

        internal Cancelada cancelada;
        internal Creada creada;
        internal EnEspera enEspera;
        internal Enviada enviada;
        internal Verificada verificada;
        public void InicializarEstados()
        {
            cancelada = new Cancelada(this);
            creada = new Creada(this);
            enEspera = new EnEspera(this);
            enviada = new Enviada(this);
            verificada = new Verificada(this);
        }

    }
}