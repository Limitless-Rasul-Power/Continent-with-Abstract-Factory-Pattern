using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class Giraffe : IHerbivorous
    {
        public Giraffe()
        {
            Speed = 60;
            Food = "leaves and buds on trees and shrubs";
            Kind = "Masai giraffe";

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
            Console.WriteLine("Burst");
        }
    }
}
