using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class DomesticCat : ICarnivorous
    {

        public DomesticCat()
        {
            Speed = 48;
            Type = "land carnivores";
            Food = "small rodents, such as mice and rats";
            Kind = "Persian cat";
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
            Console.WriteLine("meoooow");
        }
    }
}
