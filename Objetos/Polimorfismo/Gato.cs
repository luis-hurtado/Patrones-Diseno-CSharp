namespace Objetos.Polimorfismo
{
    class Gato : Animal
    {
        public Gato() : base()
        {
            Sonido = "Miauu, miau";
        }

        public override void Jugar()
        {
            System.Console.WriteLine("Jugando con el obillo de lana...");
        }
    }
}
