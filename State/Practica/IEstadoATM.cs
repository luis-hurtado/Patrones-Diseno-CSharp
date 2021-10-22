namespace State.Practica
{
    internal interface IEstadoATM
    {
        void InsertaTarjeta();
        void DevuelveTarjeta();
        void IntroducePin(int pinIngresado);
        void SolicitaDinero(int montoSolicitado);
    }
}