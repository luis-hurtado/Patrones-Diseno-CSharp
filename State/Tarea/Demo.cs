using static State.Tarea.Compra;

namespace State.Tarea
{
    public class Demo
    {
        public static void Ejecutar()
        {
            Compra orden1 = new Compra();
            orden1.Comprar(precio:800, formaPago:FormasPago.TARJETA_CREDITO, FormasEnvio.TNT);
            orden1.Verificar();
            orden1.Enviar();

            Compra orden2 = new Compra();
            orden2.Cancelar();
            orden2.Comprar(precio: 350, formaPago: FormasPago.TARJETA_CREDITO, FormasEnvio.SEUR);
            orden2.Verificar();
            orden2.Enviar();

            Compra orden3 = new Compra();
            orden3.Comprar(precio: 500, formaPago: FormasPago.PAYPAL, FormasEnvio.UPS);
            orden3.Cancelar();
            orden3.Verificar();
            orden3.Enviar();

            Compra orden4 = new Compra();
            orden4.Comprar(precio: 150, formaPago: FormasPago.TARJETA_CREDITO, FormasEnvio.SEUR);
            orden4.Verificar();
            orden4.Cancelar();
            orden4.Enviar();

            Compra orden5 = new Compra();
            orden5.Comprar(precio: 200, formaPago: FormasPago.PAYPAL, FormasEnvio.TNT);
            orden5.Verificar();
            orden5.Cancelar();
            orden5.Enviar();

            Compra orden6 = new Compra();
            orden6.Comprar(precio: 200, formaPago: FormasPago.PAYPAL, FormasEnvio.TNT);
            orden6.Enviar();
            orden6.Verificar();
            orden6.Enviar();

            Compra orden7 = new Compra();
            orden7.Verificar();
            orden7.Enviar();
            orden7.Cancelar();
            orden7.Comprar(precio: 200, formaPago: FormasPago.PAYPAL, FormasEnvio.TNT);
        }
    }
}
