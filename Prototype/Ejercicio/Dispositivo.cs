using System;

namespace Prototype.Ejercicio
{
    internal class Dispositivo : IDispositivo
    {
        public Guid Guid { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public string Duenio { get; set; }
        public IDispositivo Clonar()
        {
            Console.WriteLine($"Clonando el dispositivo - Marca: {Marca}, Modelo: {Modelo}, Precio: {Precio}");
            // Aqui se puede hacer la copia propiedad por propiedad
            return MemberwiseClone() as IDispositivo;
        }
        public override string ToString()
        {
            return $"Guid: {Guid}\tMarca: {Marca}\tModelo: {Modelo}\tPrecio: {Precio}\tDueño: {Duenio}\t\n";
        }
    }
}
