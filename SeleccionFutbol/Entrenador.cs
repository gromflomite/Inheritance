using System;

namespace SeleccionFutbol
{
    internal class Entrenador : SeleccionFutbol // Hereda la clase SeleccionFutbol
    {
        // Atributos específicos no heredados
        public string idFederacion { get; set; }

        public Entrenador(string idFederacion, int id, string nombre, string apellidos, int edad) : base(id, nombre, apellidos, edad) // :base --> Trae los valores comunes
        {
            this.idFederacion = idFederacion;
        }

        public void dirigirPartido()
        {
            Console.WriteLine($"{Nombre}{Apellidos} dirige el partido.");
        }

        public void dirigirEntrenamiento()
        {
            Console.WriteLine($"{Nombre}{Apellidos} dirige el entrenamiento.");
        }

        public override void MostrarDatos() // "override" --> Viene del "virtual" de SeleccionFutbol
        {
            base.MostrarDatos(); // Toma los atributos COMUNES del MostrarDatos() de SeleccionFutbol
            Console.WriteLine($" Id de Federación: {idFederacion}"); // Añade los atributos específicos
        }

        public override void Accion()
        {
            dirigirEntrenamiento();
        }
    }
}