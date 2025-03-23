namespace TaskmasterModels
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Task> Tasks { get; set; }

        public int HouseholdId { get; set; }
        public Household Household { get; set; }
    }
}
