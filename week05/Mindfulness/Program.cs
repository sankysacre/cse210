// Exceeding Core Requirements Statement:
// To earn full credit for exceeding core requirements, I added a non-repeating prompt and question 
// algorithm to both ReflectingActivity and ListingActivity. Each class maintains a tracking list of 
// unused items. When selected, items are removed from this list so that no duplicate prompt or 
// question appears in a single session until all available choices have been used at least once.

using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "";

            while (userChoice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;
                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}