namespace Thor.Data.Models
{
    public class CableNetBill: UtilityBill
    {
        public CableNetBill(string? companyName, int year, string? month, decimal payed) : base(companyName, year, month, payed)
        {
        }
    }
}
