namespace TaskmasterModels
{
    public class TaskHistory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime CompletionDate { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; }

        public int? TaskId { get; set; }
    }
}
