using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage
{
    class Vehicle
    {
        public int HorsePower { get; set; }

        public Vehicle(int horsePower)
        {
            HorsePower = horsePower;
        }

        public void Start()
        {
            Console.WriteLine("The engine has started.");
        }

        public void  Stop()
        {
            Console.WriteLine("The engine has stoped.");
        }

        public virtual void  MostrarDatos() //"virtual" --> Padre
        {
            Console.WriteLine($"Caballos de fuerza: {HorsePower}");
            
        }
    }
}
