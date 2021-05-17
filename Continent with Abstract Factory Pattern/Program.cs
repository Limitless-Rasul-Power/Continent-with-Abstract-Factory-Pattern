using Continent_with_Abstract_Factory_Pattern.Interfaces;
using System;

namespace Continent_with_Abstract_Factory_Pattern
{
    class Program
    {        
        static void Main(string[] args)
        {
            string[] menu = Configuration.GetContinentMenu();
            byte menuLength = Convert.ToByte(menu.Length);
            IContinent continent = null;
            IAnimal[] animals = null;

            while (true)
            {
                for (byte i = 0; i < menuLength; i++)
                {
                    Console.WriteLine($"{i + 1}) {menu[i]}");
                }
                Console.Write("\nSelect one of this continents: ");
                bool isNumber = byte.TryParse(Console.ReadLine(), out byte choiceNumber);

                while (isNumber == false || Verify.IsChoiceExist(choiceNumber, menuLength) == false)
                {
                    Console.Write("Enter one of this numbers please: ");
                    isNumber = byte.TryParse(Console.ReadLine(), out choiceNumber);
                }

                switch (choiceNumber)
                {
                    case ContinentNumbers.DomesticCarnivorousContinent:
                        {
                            continent = new DomesticCarnivorousContinent();
                        }
                        break;
                    case ContinentNumbers.DomesticHerbivorousContinent:
                        {
                            continent = new DomesticHerbivorousContinent();
                        }
                        break;
                    case ContinentNumbers.WildCarnivorousContinent:
                        {
                            continent = new WildCarnivorousContinent();
                        }
                        break;
                    case ContinentNumbers.WildHerbivorousContinent:
                        {
                            continent = new WildHerbivorousContinent();
                        }
                        break;
                }

                Console.Clear();

                animals = continent.CreateAnimals();
                byte animalsLength = Convert.ToByte(animals.Length);

                Console.WriteLine($"Animals in {menu[choiceNumber - 1]}\n");

                for (byte i = 0; i < animalsLength; i++)
                {
                    animals[i].Eat();
                    Console.Write("Noise with text: ");
                    animals[i].Speak();
                    Console.WriteLine();
                }

                Console.Write("Press any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}