using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class Elephant : IHerbivorous
    {
        public Elephant()
        {
            Speed = 40;
            Food = "roots, grasses, fruit, and bark";
            Kind = "African elephant";

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
            Console.WriteLine("Trump");
        }
    }
}
