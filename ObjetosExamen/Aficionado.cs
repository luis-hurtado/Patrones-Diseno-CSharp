namespace Patrones.Esenciales.POO.Examen
{
    internal class Aficionado : Persona
    {
        public EquipoFutbol EquipoFavorito { get; set; }
        public JugadorFutbol JugadorFavorito { get; set; }


        public Aficionado(string aficionado, EquipoFutbol equipoFutbol, JugadorFutbol jugador) : base()
        {
            //nombre = nombreJugador; // cambiar el acceso a el atributo
            Setnombre(aficionado);
            EquipoFavorito = equipoFutbol;
            JugadorFavorito = jugador;
        }

        public Aficionado(string nuevoNombre, int nuevaEdad, char nuevoGenero, int nuevoPeso, int nuevaAltura
            , EquipoFutbol equipo, JugadorFutbol jugador)
            : base(nuevoNombre, nuevaEdad, nuevoGenero, nuevoPeso, nuevaAltura)
        {
            EquipoFavorito = equipo;
            JugadorFavorito = jugador;
        }

        public override string ToString()
        {
            string retorno = base.ToString() + '\n' +
                "Equipo Favorito: " + EquipoFavorito.GetNombreEquipo() + '\n' +
                "Jugador Favorito: " + JugadorFavorito.Getnombre();

            return retorno;
        }
    }
}
