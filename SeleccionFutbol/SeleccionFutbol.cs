using System;

namespace SeleccionFutbol
{
    internal class SeleccionFutbol
    {
        // Atributos comunes
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public SeleccionFutbol(int id, string nombre, string apellidos, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public virtual void MostrarDatos() // "virtual" --> Padre. Las hijas lo podrán modificar.
        {
            Console.WriteLine($"\n ID: {Id} \n Nombre: {Nombre} \n Apellidos: {Apellidos} \n Edad: {Edad}"); // Atributos comunes
        }

        public void Concentrarse()
        {
            Console.WriteLine(" Se ha concentrado.");
        }

        public void Viajar()
        {
            Console.WriteLine($" Ha viajado.");
        }

        public virtual void Accion()
        {
        }
    }
}