using System;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
        public ReflectionActivity(int duration) : base(duration)
        {
            Description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        }

        protected override void ShowStartMessage()
        {
            Console.WriteLine($"Starting Reflection Activity...");
            Console.WriteLine(Description);
        }

        public void StartReflection()
        {
            StartActivity();
            string[] prompts = {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            string selectedPrompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(selectedPrompt);
            Thread.Sleep(5000); // Time to think about the prompt

            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            int endTime = Environment.TickCount + Duration * 1000;
            while (Environment.TickCount < endTime)
            {
                string question = questions[new Random().Next(questions.Length)];
                Console.WriteLine(question);
                Countdown(5); // Pause for reflection
            }
            ShowEndMessage();
        }
    }
}
