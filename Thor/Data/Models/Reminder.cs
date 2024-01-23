namespace Thor.Data.Models
{
    public class Reminder: BaseModel
    {
        public long? UserId { get; set; }

        public string? Name { get; set; }

        public DateTime? Date { get; set; }
    }
}
