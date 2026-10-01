using System;
using System.Collections.Generic;

namespace Mindfulness
{
    // Derived class that prompts the user to list items within a given timeframe
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;
        private List<string> _unusedPrompts;
        private Random _random;

        public ListingActivity() 
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _random = new Random();
            _count = 0;

            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            _unusedPrompts = new List<string>(_prompts);
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            List<string> items = GetListFromUser();
            _count = items.Count;

            Console.WriteLine($"You listed {_count} items!");

            DisplayEndingMessage();
        }

        // Ensures prompts do not repeat until all have been selected once
        public string GetRandomPrompt()
        {
            if (_unusedPrompts.Count == 0)
            {
                _unusedPrompts = new List<string>(_prompts);
            }

            int index = _random.Next(_unusedPrompts.Count);
            string prompt = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);
            return prompt;
        }

        public List<string> GetListFromUser()
        {
            List<string> userInputs = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userInputs.Add(input);
                }
            }

            return userInputs;
        }
    }
}