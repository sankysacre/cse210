/*
EXCEEDING CORE REQUIREMENTS:
1. Scripture Library Feature:
   - Added a library of multiple scriptures (single verse and verse range examples).
   - The program randomly selects one scripture from the library on launch to present to the user.

2. Smart Word Hiding Stretch Challenge:
   - Instead of picking completely random words (which might re-select already hidden words), 
     Scripture.cs filter-selects ONLY from words that are NOT yet hidden. This ensures consistent progress 
     toward hiding the entire verse efficiently without wasted iterations.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Doctrine and Covenants", 6, 36),
                "Look unto me in every thought; doubt not, fear not."
            )
        };

        // Select a scripture at random
        Random random = new Random();
        Scripture selectedScripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            if (selectedScripture.IsCompletelyHidden())
            {
                break;
            }

            // Hide 3 words per turn
            selectedScripture.HideRandomWords(3);
        }

        // Final display once all words are hidden or when loop finishes
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden or session ended. Good job!");
    }
}