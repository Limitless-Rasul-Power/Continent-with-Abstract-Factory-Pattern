namespace Continent_with_Abstract_Factory_Pattern
{
    public static class Verify
    {
        public static bool IsChoiceExist(byte input, byte lastChoice)
        {
            return input >= 1 && input <= lastChoice;
        }
    }
}