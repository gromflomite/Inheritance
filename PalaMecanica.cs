using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage
{
    class PalaMecanica : Vehicle
    {
        public int MaxKg { get; set; }

        public PalaMecanica(int maxKg, int horsePower, string marca):base(horsePower)
        {
            MaxKg = maxKg;
        }
    }
}
