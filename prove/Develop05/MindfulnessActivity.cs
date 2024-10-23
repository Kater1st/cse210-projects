using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int Duration { get; set; }
        protected string Description { get; set; }

        public MindfulnessActivity(int duration)
        {
            Duration = duration;
        }

        public void StartActivity()
        {
            ShowStartMessage();
            Thread.Sleep(2000); // Pause before starting
        }

        protected abstract void ShowStartMessage();

        protected void ShowEndMessage()
        {
            Console.WriteLine("Good job! You completed the activity.");
            Console.WriteLine($"Duration: {Duration} seconds.");
            Thread.Sleep(2000);
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
