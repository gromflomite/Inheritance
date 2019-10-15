using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage
{
    class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(int doors, int horsePower):base(horsePower) // Le decimos que como segundo argumento (int horsepower) lo ha de heredar desde la clase padre (Vehicle) 
        {
            Doors = doors;
            
        }

        public void Forward(int howMuch)
        {
            Start(); // Con la herencia, podemos llamar al método desde aquí.
            Console.WriteLine($"Have you going forward at {howMuch}");
        }

        public override void MostrarDatos() // "override" --> Hijo
        {
            base.MostrarDatos();
            Console.WriteLine($"Cantidad de puertas: {Doors}");
            
        }
    }
}
