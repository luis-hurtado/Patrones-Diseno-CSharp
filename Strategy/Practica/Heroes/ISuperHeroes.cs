using Strategy.Practica.Habilidad;

namespace Strategy.Practica.Heroes
{
    internal interface ISuperHeroes
    {
        void UsarHabilidades();
        void CambiarSuperPoder(ISuperPoder power);
        void ObtenerNombreReal();
        void PerderPoderes();
    }
}