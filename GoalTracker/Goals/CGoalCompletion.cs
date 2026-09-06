using System;
using System.Collections.Generic;
using System.Text;

namespace GoalTracker.Goals
{
    public class CGoalCompletion
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid GoalId { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }
    }
}
