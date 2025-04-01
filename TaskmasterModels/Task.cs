using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace TaskmasterModels
{
    public class Task
    {
        public enum RecurranceType
        {
            Standard = 0,
            [Display(Name = "Day of the Week")]
            DayOfWeek = 1
        }

        public enum DateInterval
        {
            Day = 0,
            Week = 1,
            Month = 2,
            Weekday = 3,
            Year = 4,
            Quarter = 5,
        }

        [NotMapped]
        public bool IsNew { get; set; } = false;
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
        public RecurranceType? RecurranceTypeId { get; set; }
        public int? RecurranceQuantity { get; set; }

        public DateTime? DueDate { get; set; }

        public DayOfWeek? DayOfWeek { get; set; }

        public DateInterval? Interval { get; set; }

        public Task()
        {
            IsNew = true;
            RecurranceQuantity = 1;
        }

       
    }
}
