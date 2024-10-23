using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity(int duration) : base(duration)
        {
            Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void ShowStartMessage()
        {
            Console.WriteLine($"Starting Breathing Activity...");
            Console.WriteLine(Description);
        }

        public void StartBreathing()
        {
            StartActivity();
            int endTime = Environment.TickCount + Duration * 1000;
            while (Environment.TickCount < endTime)
            {
                Console.WriteLine("Breathe in...");
                Countdown(4);
                Console.WriteLine("Breathe out...");
                Countdown(4);
            }
            ShowEndMessage();
        }
    }
}
