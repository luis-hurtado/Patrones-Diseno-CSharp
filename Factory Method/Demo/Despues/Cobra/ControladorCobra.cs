namespace Factory_Method.Demo.Despues.Cobra
{
    internal class ControladorCobra : Controlador
    {
        public override IMotorVista CrearMotorVista()
        {
            return new MotorVistaCobra();
        }
    }
}
