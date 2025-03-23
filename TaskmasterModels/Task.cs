using Microsoft.VisualBasic;

namespace TaskmasterModels
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsComplete { get; set; } = false;
        public int HouseholdId { get; set; }
        public Household Household { get; set; }

        public int? MemberId { get; set; }
        public Member? Member { get; set; }

        public int? CateogryId { get; set; }
        public Category? Category { get; set; }

        public bool Recurring { get; set; } = false;
        public int? RecurranceQuantity { get; set; }

        public DateTime? DueDate { get; set; }

        public DayOfWeek? DayOfWeek { get; set; }

        public DateInterval? Interval { get; set; }
    }
}
