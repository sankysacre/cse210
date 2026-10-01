using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity()
        {
            _name = "";
            _description = "";
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
        }

        public void DisplayEndingMessage()
        {
        }

        public void ShowSpinner(int seconds)
        {
        }

        public void ShowCountDown(int seconds)
        {
        }
    }
}