using System;

namespace SeleccionFutbol
{
    internal class Masajista : SeleccionFutbol // Hereda la clase SeleccionFutbol
    {
        public string Titulacion { get; set; }

        // Atributos específicos no heredados
        public int AnosExperiencia { get; set; }

        public Masajista(string titulacion, int anosExperiencia, int id, string nombre, string apellidos, int edad) : base(id, nombre, apellidos, edad) // :base --> Trae los valores comunes
        {
            Titulacion = titulacion;
            AnosExperiencia = anosExperiencia;
        }

        public void darMasaje()
        {
            Console.WriteLine($"{Nombre}{Apellidos} da un masaje.");
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($" Titulación: {Titulacion} \n Años de experiencia: {AnosExperiencia}");
        }

        public override void Accion()
        {
            darMasaje();
        }
    }
}