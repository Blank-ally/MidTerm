using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    internal class Margret : Driver
    {
        public Margret(RaceCar car) : base(car)
        {
            Name = "Margret";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
