using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryController
    {
        List<Country> CountryDB = new List<Country>()
        {
            new Country("USA", "North America", new List<string> {"red", "white", "blue" }),
            new Country("Canada", "North America", new List<string> {"red", "white" }),
            new Country("Brazil", "South America", new List<string> {"green", "yellow" }),
            new Country("Germany", "Europe", new List<string> {"black", "red", "gold" }),
            new Country("China", "Asia", new List<string> {"red", "yellow" }),
            new Country("Australia", "Oceania", new List<string> {"green", "gold" }),
            new Country("South Africa", "Africa", new List<string> {"black", "green", "gold" }),
            new Country("India", "Asia", new List<string> {"saffron", "white", "green" }),
            new Country("Mexico", "North America", new List<string> {"green", "white", "red" }),
            new Country("Italy", "Europe", new List<string> {"green", "white", "red" })
        };
        public void CountryAction(Country c)
        {
            
            CountryView view = new CountryView(c);
            view.Display();
        }
        public void WelcomeAction()
        {
            do
            {
                CountryListView view = new CountryListView(CountryDB);
                view.Display();
                Console.WriteLine("Please choose a Country by it's corresponding number");
                int choice = GetPositiveInputInt(CountryDB);
                CountryAction(CountryDB[choice]);
            } while (GetContinue("Would you like to learn about another Country?"));
        }
        //change color
       

        //validation methods 
        public static int GetPositiveInputInt(List<Country> CountryDB)
        {
            int result = -1;
            while (!int.TryParse(Console.ReadLine(), out result)|| result < 0 || result >= CountryDB.Count)
            {
                Console.WriteLine("Invalid input. Try again with a number on this list.");
            }
            return result;
        }
        public static bool GetContinue(string message)
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }
    }
}
