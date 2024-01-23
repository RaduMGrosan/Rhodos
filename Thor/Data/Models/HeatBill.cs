namespace Thor.Data.Models
{
    public class HeatBill: UtilityBill
    {
        public HeatBill(string? companyName, int year, string? month, decimal payed) : base(companyName, year, month, payed)
        {
        }
    }
}
