namespace Patrones.Esenciales.POO.Examen
{
    internal class EquipoFutbol
    {
        private string nombreEquipo;

        public EquipoFutbol(): this("Bolivar")
        {
                
        }

        public EquipoFutbol(string nombre)
        {
            nombreEquipo = nombre;
        }

        public string GetNombreEquipo()
        {
            return nombreEquipo;
        }

        public void SetNombreEquipo(string value)
        {
            nombreEquipo = value;
        }
    }
}
