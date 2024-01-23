namespace Thor.Data.Models
{
    public class GarbageBill: UtilityBill
    {
        public GarbageBill(string? companyName, int year, string? month, decimal payed) : base(companyName, year, month, payed)
        {
        }
    }
}
