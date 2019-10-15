using System.Collections.Generic;

namespace Heritage
{
    internal class TheoryCode
    {
        private static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle(180);
            Car c1 = new Car(5, 180);
            PalaMecanica pm1 = new PalaMecanica(45000, 540, "JBC");

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(v1);
            vehicles.Add(c1);
            vehicles.Add(pm1);

            foreach (Vehicle vehicle in vehicles)
            {
                
            }


            c1.Forward(30);


        }
    }
}