using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MindfulnessApp
{
    public class MindfulnessApp
    {
        private Dictionary<string, Func<int, MindfulnessActivity>> activities;
        private UserPreferences userPreferences;

        public MindfulnessApp()
        {
            activities = new Dictionary<string, Func<int, MindfulnessActivity>>
            {
                { "1", duration => new BreathingActivity(duration) },
                { "2", duration => new ReflectionActivity(duration) },
                { "3", duration => new ListingActivity(duration) }
            };
            userPreferences = LoadPreferences();
        }

        private UserPreferences LoadPreferences()
        {
            if (File.Exists("preferences.json"))
            {
                string json = File.ReadAllText("preferences.json");
                return JsonSerializer.Deserialize<UserPreferences>(json);
            }
            return new UserPreferences();
        }

        private void SavePreferences()
        {
            string json = JsonSerializer.Serialize(userPreferences);
            File.WriteAllText("preferences.json", json);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                string choice = Console.ReadLine();
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                var activity = activities[choice](duration);

                switch (activity)
                {
                    case BreathingActivity breathingActivity:
                        breathingActivity.StartBreathing();
                        break;
                    case ReflectionActivity reflectionActivity:
                        reflectionActivity.StartReflection();
                        break;
                    case ListingActivity listingActivity:
                        listingActivity.StartListing();
                        break;
                }

                userPreferences.LastActivity = activity.GetType().Name;
                SavePreferences();

                Console.Write("Do you want to do another activity? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") break;
            }
        }
    }
}
