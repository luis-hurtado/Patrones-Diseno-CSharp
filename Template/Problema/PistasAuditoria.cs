using System;

namespace Template.Problema
{
    internal class PistasAuditoria
    {
        public void CrearLog(string proceso, string usuario)
        {
            var fecha = DateTime.Now;
            Console.WriteLine($"{fecha.ToShortDateString()} {fecha.ToShortTimeString()}-Se esta generando la pista de auditoria para el proceso {proceso}, realizado por el usuario {usuario}");
        }
    }
}