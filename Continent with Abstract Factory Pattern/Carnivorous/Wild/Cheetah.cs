using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class Cheetah : ICarnivorous
    {

        public Cheetah()
        {
            Speed = 130;
            Type = "land carnivores";
            Food = "zebras, gazelles and some birds";
            Kind = "Tanzanian cheetah";
        }

        public double Speed { get; set; }
        public string Type { get; set; }
        public string Food { get; set; }
        public string Kind { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Kind} is a type of {Type} and can eat {Food}.");
        }

        public void Speak()
        {
            Console.WriteLine("MEOWWWWW");
        }
    }
}
