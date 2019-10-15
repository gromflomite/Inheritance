using System;

namespace SeleccionFutbol
{
    internal class Futbolista : SeleccionFutbol // Hereda la clase SeleccionFutbol
    {
        // Atributos específicos no heredados
        public int Dorsal { get; set; }

        public string Demarcacion { get; set; }

        public Futbolista(int dorsal, string demarcacion, int id, string nombre, string apellidos, int edad) : base(id, nombre, apellidos, edad) // :base --> Trae los valores comunes
        {
            Dorsal = dorsal;
            Demarcacion = demarcacion;
        }

        public void JugarPartido()
        {
            Console.WriteLine($" {Nombre} {Apellidos} juega el partido.");
        }

        public void Entrenar()
        {
            Console.WriteLine($" {Nombre} {Apellidos} entrena.");
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($" Dorsal: {Dorsal} \n Demarcación: {Demarcacion}");
        }

        public override void Accion()
        {
            Entrenar();
        }
    }
}