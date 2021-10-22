namespace Patrones.Esenciales.POO.Examen
{
    internal class JugadorFutbol:Persona
    {
        public EquipoFutbol Equipo { get; set; }

        public JugadorFutbol(string nombreJugador, EquipoFutbol equipoFutbol): base()
        {
            //nombre = nombreJugador; // cambiar el acceso a el atributo
            this.Setnombre(nombreJugador);
            Equipo = equipoFutbol;
        }

        public JugadorFutbol(string nuevoNombre, int nuevaEdad,char nuevoGenero,int nuevoPeso,int nuevaAltura, EquipoFutbol equipo) 
            : base(nuevoNombre, nuevaEdad, nuevoGenero, nuevoPeso, nuevaAltura)
        {
            Equipo = equipo;
        }


        public override string ToString()
        {
            string retorno = base.ToString() + '\n' +
                "Equipo: " + Equipo.GetNombreEquipo();

            return retorno;
        }
    }
}
