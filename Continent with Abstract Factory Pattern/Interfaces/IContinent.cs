using Continent_with_Abstract_Factory_Pattern.Interfaces;

namespace Continent_with_Abstract_Factory_Pattern
{
    public interface IContinent
    {
        IAnimal[] CreateAnimals();
    }
}