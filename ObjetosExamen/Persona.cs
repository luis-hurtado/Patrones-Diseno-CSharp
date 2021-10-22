using System;

namespace Patrones.Esenciales.POO.Examen
{
    //internal abstract class Persona
    internal class Persona
    {
        #region Constantes

        private const int MAYORIA_DE_EDAD = 18;
        private const double PESO_MINIMO = 18.5;
        private const int PESO_MAXIMO = 25;

        #endregion

        #region Atributos

        private string nombre;
        private int edad;
        private char genero;
        private int peso;
        private int altura;

        #endregion

        #region Propiedades (Setters / Getters)

        public string Getnombre()
        {
            return nombre;
        }

        public void Setnombre(string value)
        {
            nombre = value;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int value)
        {
            edad = value;
        }


        public char GetGenero()
        {
            return genero;
        }

        public void SetGenero(char value)
        {            
            genero = value;
        }


        public int GetPeso()
        {
            return peso;
        }

        public void SetPeso(int value)
        {
            peso = value;
        }


        public int GetAltura()
        {
            return altura;
        }

        public void SetAltura(int value)
        {
            altura = value;
        }

        #endregion

        #region Metodos
        public int CalcularIMC()
        {
            double alturaEnMetros = (double)altura / 100;  
            double IMC = peso / Math.Pow(alturaEnMetros,2);
            int retorno = 0;
            if (IMC < PESO_MINIMO)
                retorno = -1;
            else if (IMC > PESO_MAXIMO)
                retorno = 1;

            return retorno;
        }

        public bool EsMayorDeEdad()
        {
            return edad > MAYORIA_DE_EDAD;
        }

        private char ComprobarGenero(char nuevoGenero)
        {
            return nuevoGenero != 'H' || nuevoGenero != 'M' ? 'H' : nuevoGenero;
        }

        public override string ToString()
        {

            string cadena =
                "Nombre:" + nombre + '\n' +
                "edad:" + edad + '\n' +
                "genero:" + genero + '\n' +
                "peso:" + peso + '\n' +
                "altura:" + altura + '\n';
            return cadena;
        }
        #endregion

        #region Constructores de la clase
        public Persona(): this("",0,'H',0,0)
        {
            
        }

        public Persona(
            string nuevoNombre,
            int nuevaEdad,
            char nuevoGenero,
            int nuevoPeso,
            int nuevaAltura
            )
        {
            nombre = nuevoNombre;
            edad = nuevaEdad;
            genero = ComprobarGenero(nuevoGenero);
            peso = nuevoPeso;
            altura = nuevaAltura;
        }

        #endregion
    }
}
