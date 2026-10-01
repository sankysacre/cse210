using System;
using System.Threading;

namespace Mindfulness
{
    // Base class containing shared attributes and helper behaviors for all activities
    public class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        // Displays standard welcome text and prompts for duration
        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine($"{_description}\n");
            Console.Write("How long, in seconds, would you like for your session? ");

            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid number of seconds: ");
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
        }

        // Displays standard conclusion text and summary
        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(4);
        }

        // Displays a rotating spinner animation for the specified duration
        public void ShowSpinner(int seconds)
        {
            string[] animationFrames = { "|", "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int frameIndex = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(animationFrames[frameIndex]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                frameIndex = (frameIndex + 1) % animationFrames.Length;
            }
        }

        // Displays an inline countdown timer for the specified duration
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}