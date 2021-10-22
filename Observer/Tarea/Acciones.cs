namespace Observer.Tarea
{
    class Acciones : SujetoObservable
    {
        int dato;
        
        public int Dato
        {
            get => dato;
            set
            {
                dato = value;
                ActualizarObservadores(dato);
            }
        }        
    }
}
