
using System;
using System.Collections.Generic;

namespace Factory_Method.Demo.Despues
{
    internal abstract class Controlador
    {
        public void Renderizar(string nombreVista, IDictionary<string, object> contexto)
        {
            var motor = CrearMotorVista();
            var html = motor.Renderizar(nombreVista, contexto);
            Console.WriteLine(html);
        }

        public abstract IMotorVista CrearMotorVista();

        //public virtual IMotorVista CrearMotorVista()
        //{
        //    return new Cobra.MotorVistaCobra();
        //}

    }
}
