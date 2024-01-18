namespace Thor.Data.Services.Interfaces
{
    public interface IUtilityBillService
    {
        Task<UtilityBill[]> GetBillsAsync();
    }
}
