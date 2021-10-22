using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Tarea
{
    internal abstract class Trabajador
    {
        protected string nombre;
        protected string profesion;
        public void RutinaDiaria()
        {
            Despertar();
            Desayunar();
            IrATrabajar();
            Trabajar();
            RegresarACasa();
            Relajarse();
            Dormir();
        }


        protected virtual void Despertar() 
        {
            Console.WriteLine($"{nombre} a despertado.");
        }
        protected virtual void Desayunar()
        {
            Console.WriteLine($"{nombre} esta desayunando.");
        }
        protected virtual void IrATrabajar()
        {
            Console.WriteLine($"{nombre} salio a trabajar.");
        }
        protected abstract void Trabajar();
        protected virtual void RegresarACasa()
        {
            Console.WriteLine($"{nombre} esta volviendo a casa.");
        }
        protected abstract void Relajarse();

        protected virtual void Dormir()
        {
            Console.WriteLine($"{nombre} Se fue a dormir.");
        }

    }
}
