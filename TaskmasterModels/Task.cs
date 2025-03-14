namespace TaskmasterModels
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsComplete { get; set; } = false;

        public DateTime? DueDate { get; set; }

        public int HouseholdId { get; set; }
        public Household Household { get; set; }
    }
}
