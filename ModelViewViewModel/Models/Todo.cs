namespace ModelViewViewModel.Models
{
    public class Todo
    {
        public required string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Nullable<DateTime> CompltedAt { get; set; }
        public Status Status { get; set; }
    }
}
