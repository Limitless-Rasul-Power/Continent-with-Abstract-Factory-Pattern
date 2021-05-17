using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class Goat : IHerbivorous
    {

        public Goat()
        {
            Speed = 35;
            Food = "hay, grasses, weeds, grain, and sometimes even tree bark";
            Kind = "Kiko goat";
        }

        public double Speed { get; set; }
        public string Food { get; set; }
        public string Kind { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Kind} can eat {Food}!");
        }

        public void Speak()
        {
            Console.WriteLine("Maaa");
        }
    }
}
