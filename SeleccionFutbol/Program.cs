using System;
using System.Collections.Generic;

namespace SeleccionFutbol
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Entrenador e1 = new Entrenador("322B", 1, "Francisco", "Ramírez", 25);
            Masajista m1 = new Masajista("Fisioterapeuta", 30, 122, "José", "Blasco", 48);
            Masajista m2 = new Masajista("Astrónomo", 21, 715, "Pablo", "Iglesias", 27);
            Futbolista f1 = new Futbolista(9, "Portero", 211, "Ramiro", "Maeztu", 24);
            Futbolista f2 = new Futbolista(8, "Delantero", 983, "Lopez", "Ibor", 34);
            Futbolista f3 = new Futbolista(2, "Defensa", 224, "Sanchez", "Castejón", 21);

            List<SeleccionFutbol> seleccionElegida = new List<SeleccionFutbol>();
            seleccionElegida.Add(e1);
            seleccionElegida.Add(m1);
            seleccionElegida.Add(m2);
            seleccionElegida.Add(f1);
            seleccionElegida.Add(f2);
            seleccionElegida.Add(f3);

            foreach (SeleccionFutbol miembro in seleccionElegida)
            {
                miembro.MostrarDatos();
                miembro.Viajar();
                miembro.Concentrarse();
                miembro.Accion();
                Console.WriteLine(" " + miembro.GetType().Name); // Extrae el nombre de la clase (Masajista.cs - Futbolista.cs ...)
            }

            SeleccionPais s1 = new SeleccionPais("Andorra", seleccionElegida, 24);
            SeleccionPais s2 = new SeleccionPais("Alemania", seleccionElegida, 42);
            SeleccionPais s3 = new SeleccionPais("Brasil", seleccionElegida, 18);

            s1.MostrarDatosSeleccion();

            s1.AltaSeleccion();
        }
    }
}