using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        public ListingActivity(int duration) : base(duration)
        {
            Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
        }

        protected override void ShowStartMessage()
        {
            Console.WriteLine($"Starting Listing Activity...");
            Console.WriteLine(Description);
        }

        public void StartListing()
        {
            StartActivity();
            string[] prompts = {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt grateful this month?",
                "Who are some of your personal heroes?"
            };
            string selectedPrompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(selectedPrompt);
            Thread.Sleep(5000); // Time to think about the prompt

            List<string> items = new List<string>();
            int endTime = Environment.TickCount + Duration * 1000;
            while (Environment.TickCount < endTime)
            {
                Console.Write("List an item (or type 'done' to finish): ");
                string item = Console.ReadLine();
                if (item.ToLower() == "done") break;
                items.Add(item);
            }
            Console.WriteLine($"You listed {items.Count} items.");
            ShowEndMessage();
        }
    }
}
