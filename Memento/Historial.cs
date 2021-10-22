using System.Collections.Generic;

namespace Memento
{
    public class Historial
    {
        IList<EstadoEditor> estados = new List<EstadoEditor>();

        public void Push(EstadoEditor estado)
        {
            estados.Add(estado);
        }

        public EstadoEditor Pop()
        {
            var indice = estados.Count - 1;
            var ultimoEstado = estados[indice];
            estados.Remove(ultimoEstado);
            return ultimoEstado;
        }
    }
}
