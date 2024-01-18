namespace Thor.Data.Models
{
    public class MaintenanceBill: UtilityBill
    {
        public MaintenanceBill(string? companyName, int year, string? month, decimal payed) : base(companyName, year, month, payed)
        {
            Type = Enums.BillTypeEnum.Maintenance;
        }
    }
}
