// EternalGoal.cs
using System;

namespace GoalTracking
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string description, int points) : base(description, points) { }

        public override void CompleteGoal()
        {
            // Update score without setting _isComplete to true
        }

        public override string DisplayGoalStatus()
        {
            return "[∞] " + _description; // Infinity symbol to denote eternal
        }
    }
}
