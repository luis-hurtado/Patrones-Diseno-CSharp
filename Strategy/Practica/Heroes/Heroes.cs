using Strategy.Practica.Habilidad;

namespace Strategy.Practica.Heroes
{
    public class SpiderMan : SuperHeroe
    {
        public SpiderMan() : base(new LanzarTelarañas(), "Peter Parker")
        {
        }
    }
    public class Superman : SuperHeroe
    {
        public Superman() : base(new Volar(), "Clark Kent")
        {
        }
    }
    public class Batman : SuperHeroe
    {
        public Batman() : base(new Golpear(), "Bruce Wayne")
        {
        }
    }
}
