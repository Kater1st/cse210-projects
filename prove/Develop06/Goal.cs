// Goal.cs
using System;

namespace GoalTracking
{
    public abstract class Goal
    {
        protected string _description;
        protected int _points;
        protected bool _isComplete;

        public Goal(string description, int points)
        {
            _description = description;
            _points = points;
            _isComplete = false;
        }

        public abstract void CompleteGoal();
        public abstract string DisplayGoalStatus();
    }
}
