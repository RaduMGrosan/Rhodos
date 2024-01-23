namespace Thor.Data.Models
{
    public class Resource : BaseModel
    {
        public long? UserId { get; set; }

        public string? Name { get; set; }

        public long? Quantity { get; set; }
    }
}
