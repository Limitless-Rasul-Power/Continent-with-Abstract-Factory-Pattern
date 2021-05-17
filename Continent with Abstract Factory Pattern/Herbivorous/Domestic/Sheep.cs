using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class Sheep : IHerbivorous
    {

        public Sheep()
        {
            Speed = 2;
            Food = "Kentucky bluegrass";
            Kind = "Long wooled rams sheep";
        }

        public double Speed { get; set; }
        public string Food { get; set; }
        public string Kind { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Kind} can eat {Food}.");
        }

        public void Speak()
        {
            Console.WriteLine("bee bee");
        }
    }
}
