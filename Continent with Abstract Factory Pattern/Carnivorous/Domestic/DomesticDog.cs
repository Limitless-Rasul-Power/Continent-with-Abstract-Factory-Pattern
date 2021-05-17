using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class DomesticDog : ICarnivorous
    {

        public DomesticDog()
        {
            Speed = 130;
            Type = "land carnivores";
            Food = "250-300 gram meet per day";
            Kind = "Greyhound dog";
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
            Console.WriteLine("Bark");
        }
    }
}
