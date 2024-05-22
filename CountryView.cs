using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }

        public void Display()
        {
            Console.Write($"Name: {DisplayCountry.Name} ");
            Console.Write($"Continent: {DisplayCountry.Continent} ");
            Console.Write($"Colors: ");
            foreach (string color in DisplayCountry.Colors)
            {
                switch (color.ToLower())
                {
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "white":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "gold":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "black":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "saffron":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                }
                Console.Write($"{color}, ");
                Console.ResetColor();
            }

        }
    }
}
