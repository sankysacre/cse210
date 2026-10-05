// Program.cs
// CREATIVITY AND EXCEEDING REQUIREMENTS:
// Added a dynamic Player Leveling System based on total accumulated score 
// (calculated dynamically as: Level = (_score / 1000) + 1). 
// The player's level and rank title are dynamically calculated and displayed 
// alongside their total score at the top of the main menu.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}