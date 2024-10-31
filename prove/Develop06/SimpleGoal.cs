// SimpleGoal.cs
using System;

namespace GoalTracking
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string description, int points) : base(description, points) { }

        public override void CompleteGoal()
        {
            _isComplete = true;
            // Logic to update score or other actions
        }

        public override string DisplayGoalStatus()
        {
            return _isComplete ? "[X] " + _description : "[ ] " + _description;
        }
    }
}
