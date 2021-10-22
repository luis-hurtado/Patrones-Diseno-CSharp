using System;

namespace Patrones.Esenciales.POO.Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1
            /* 
            Persona Marco = new Persona();
            Marco.Setnombre("Marco");
            Marco.SetEdad(30);
            Marco.SetPeso(80);
            Marco.SetAltura(180); //1.8 mts

            Persona Mateo = new Persona("Mateo", 25, 'H', 90, 170);
            Persona Maria = new Persona("Maria", 17, 'M', 40, 150);

            Console.WriteLine(Mateo.ToString());
            Console.WriteLine( Mateo.EsMayorDeEdad() ? "Es mayor de edad" : "Es menor de edad");
            MostrarInformacionDelPeso(Mateo);
            Console.WriteLine("------------------------------------\n\n");

            Console.WriteLine(Marco.ToString());
            Console.WriteLine(Marco.EsMayorDeEdad() ? "Es mayor de edad" : "Es menor de edad");
            MostrarInformacionDelPeso(Marco);
            Console.WriteLine("------------------------------------\n\n");

            Console.WriteLine(Maria.ToString());
            Console.WriteLine(Maria.EsMayorDeEdad() ? "Es mayor de edad" : "Es menor de edad");
            MostrarInformacionDelPeso(Maria);
            Console.WriteLine("------------------------------------\n\n");
            */

            // Ejercicio 2
            EquipoFutbol Boliviar = new EquipoFutbol("Bolivar");
            EquipoFutbol Wilsterman = new EquipoFutbol("Bolivar");

            //JugadorFutbol jugador1 = new JugadorFutbol("Gilbert Arias", Wilsterman);
            //JugadorFutbol jugador2 = new JugadorFutbol("Diego Bejarano", 29, 'h', 75, 174, Boliviar);

            //Persona Marco = new Aficionado("Marco", Boliviar, jugador1);
            //Marco.Setnombre("Marco Antonio");
            //Marco.SetEdad(30);
            //Marco.SetPeso(80);
            //Marco.SetAltura(180); //1.8 mts

            //Persona Mateo = new Aficionado("Mateo", 25, 'H', 90, 170, Boliviar, jugador2);
            //Persona Maria = new Aficionado("Maria", 17, 'M', 40, 150, Wilsterman, jugador1);

            //Console.WriteLine(Mateo.ToString());
            //Console.WriteLine(Mateo.EsMayorDeEdad() ? "Es mayor de edad" : "Es menor de edad");
            //MostrarInformacionDelPeso(Mateo);
            //Console.WriteLine("------------------------------------\n\n");
            //Console.WriteLine(Maria.ToString());
            //Console.WriteLine(Maria.EsMayorDeEdad() ? "Es mayor de edad" : "Es menor de edad");
            //MostrarInformacionDelPeso(Maria);
            //Console.WriteLine("------------------------------------\n\n");




            Persona[] asistentesClasico = new Persona[5];
            asistentesClasico[0] = new JugadorFutbol("Gilbert Arias", Wilsterman); ;
            asistentesClasico[1] = new JugadorFutbol("Diego Bejarano", 29, 'h', 75, 174, Boliviar); ;
            asistentesClasico[2] = new Aficionado("Mateo", 25, 'H', 90, 170, Boliviar, (JugadorFutbol)asistentesClasico[1]);
            asistentesClasico[3] = new Aficionado("Maria", 17, 'M', 40, 150, Wilsterman, (JugadorFutbol)asistentesClasico[0]);
            asistentesClasico[4] = new Aficionado("Marco", Boliviar, (JugadorFutbol)asistentesClasico[0]);
            asistentesClasico[4].Setnombre("Marco Antonio");
            asistentesClasico[4].SetEdad(30);
            asistentesClasico[4].SetPeso(80);
            asistentesClasico[4].SetAltura(180); //1.8 mts

            foreach (var asistente in asistentesClasico)
            {
                Console.WriteLine(asistente.ToString());
                Console.WriteLine(asistente.EsMayorDeEdad() ? "Es mayor de edad" : "Es menor de edad");
                MostrarInformacionDelPeso(asistente);
                Console.WriteLine("------------------------------------\n\n");
            }
            Console.ReadKey();
        }

        static void MostrarInformacionDelPeso(Persona persona)
        {
            int imc = persona.CalcularIMC();
            string retorno = $"{persona.Getnombre()} esta con ";
            switch (imc)
            {
                case -1:
                    retorno += "desnutricion o algun problema de salud";
                    break;
                case 1:
                    retorno += "sobrepeso y debe hacer dieta y ejercicios";
                    break;
                default:
                    retorno += "su peso ideal";
                    break;
            }

            Console.WriteLine(retorno);
        }
    }
}

