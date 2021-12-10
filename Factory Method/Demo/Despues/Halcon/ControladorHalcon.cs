namespace Factory_Method.Demo.Despues.Halcon
{
    internal class ControladorHalcon : Controlador
    {
        public override IMotorVista CrearMotorVista()
        {
            return new MotorVistaHalcon();
        }
    }
}
