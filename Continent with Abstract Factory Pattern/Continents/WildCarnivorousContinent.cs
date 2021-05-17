using Continent_with_Abstract_Factory_Pattern.Interfaces;

namespace Continent_with_Abstract_Factory_Pattern
{
    public class WildCarnivorousContinent : IContinent
    {
        public IAnimal[] CreateAnimals()
        {
            return new IAnimal[] { new Lion(), new Cheetah() };
        }
    }
}