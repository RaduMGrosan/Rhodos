namespace Thor.Data.Models
{
    public class WaterBill: UtilityBill
    {
        public WaterBill(string? companyName, int year, string? month, decimal payed) : base(companyName, year, month, payed)
        {
            Type = Enums.BillTypeEnum.Water;
        }
    }
}
