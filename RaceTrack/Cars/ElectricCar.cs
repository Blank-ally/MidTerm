using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{

    internal class ElectricCar : RaceCar
    {

        public ElectricCar()
        {
            Name = "Electric Car";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} buzzes to life");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} grinds to a hault");
            base.Brake();
        }
    }
}
