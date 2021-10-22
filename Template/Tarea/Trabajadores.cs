using System;

namespace Template.Tarea
{
    internal class Bombero : Trabajador
    {

        public Bombero(string nombre)
        {
            this.nombre = nombre;
            this.profesion = "Bombero";
        }

        protected override void Relajarse()
        {
            Console.WriteLine($"{nombre} Salio a tomar algunas Cervezas con los amigos.");
        }

        protected override void Trabajar()
        {
            Console.WriteLine($"{nombre} es {profesion}, el  esta apagando incendios");
        }

        protected override void Desayunar()
        {
            base.Desayunar();
            Console.WriteLine($"{nombre} Desayuna doble para tener mas fuerzas.");
        }
    }

    internal class Cartero : Trabajador
    {
        public Cartero(string nombre)
        {
            this.nombre = nombre;
            this.profesion = "Cartero";
        }

        protected override void Relajarse()
        {
            Console.WriteLine($"{nombre} Cose los pantalones rotos debido a las mordidas constantes de los perros.");
        }

        protected override void Trabajar()
        {
            Console.WriteLine($"{nombre} es {profesion}, el esta repartiendo encomiendas/cartas.");
        }

        protected override void RegresarACasa()
        {
            Console.WriteLine($"{nombre} Regresa a casa en su bicicleta.");
        }
    }

    internal class Obrero : Trabajador
    {
        public Obrero(string nombre)
        {
            this.nombre = nombre;
            this.profesion = "Obrero";
        }

        protected override void Relajarse()
        {
            Console.WriteLine($"{nombre} se puso a ver peliculas en el televisor.");
        }

        protected override void Trabajar()
        {
            Console.WriteLine($"{nombre} es {profesion}, el esta construyendo casas");
        }

        protected override void Despertar()
        {
            base.Despertar();
            Console.WriteLine($"{nombre} hace ejercicios despues de despertar para mantenerse en forma.");
        }
    }

    internal class Oficinista : Trabajador
    {
        public Oficinista(string nombre)
        {
            this.nombre = nombre;
            this.profesion = "Oficinista";
        }

        protected override void Relajarse()
        {
            Console.WriteLine($"A {nombre} le gusta leer para relajarse.");
        }

        protected override void Trabajar()
        {
            Console.WriteLine($"{nombre} es {profesion}, el debe revisar y llenar muchos documentos mientras trabaja");
        }

        protected override void Dormir()
        {
            base.Dormir();
            Console.WriteLine($"{nombre} sueña con un asenso.");
        }
    }
}
