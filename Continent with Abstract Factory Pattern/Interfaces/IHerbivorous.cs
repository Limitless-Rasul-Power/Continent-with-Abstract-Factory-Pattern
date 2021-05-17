using Continent_with_Abstract_Factory_Pattern.Interfaces;

namespace Continent_with_Abstract_Factory_Pattern
{
    public interface IHerbivorous : IAnimal
    {
        double Speed { get; set; }
        string Food { get; set; }
        string Kind { get; set; }
    }
}