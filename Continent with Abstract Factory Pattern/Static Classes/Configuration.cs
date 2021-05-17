namespace Continent_with_Abstract_Factory_Pattern
{
    public static class Configuration
    {
        public static string[] GetContinentMenu()
        {
            return new string[] { "Domestic Carnivorous Continent", "Domestic Herbivorous Continent", "Wild Carnivorous Continent",
                "Wild Herbivorous Continent" };
        }
    }
}