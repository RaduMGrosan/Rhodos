using Thor.Data.Enums;

namespace Thor.Data.Models
{
    public class BillType: BaseModel
    {
        public string? Name { get; set; }
        public BillTypeEnum Value { get; set; }

    }
}
