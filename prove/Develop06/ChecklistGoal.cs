// ChecklistGoal.cs
using System;

namespace GoalTracking
{
    public class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;
        private int _bonusPoints;

        public ChecklistGoal(string description, int points, int targetCount, int bonusPoints)
            : base(description, points)
        {
            _targetCount = targetCount;
            _currentCount = 0;
            _bonusPoints = bonusPoints;
        }

        public void RecordEvent()
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _isComplete = true;
                // Logic to update score with bonus points
            }
            else
            {
                // Logic to update score with regular points
            }
        }

        public override string DisplayGoalStatus()
        {
            return _isComplete
                ? "[X] " + _description + " (Completed)"
                : "[ ] " + _description + $" (Completed {_currentCount}/{_targetCount} times)";
        }
    }
}
