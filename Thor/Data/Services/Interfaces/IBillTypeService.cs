using Thor.Data.Models;

namespace Thor.Data.Services.Interfaces
{
    public interface IBillTypeService
    {
        Task<List<BillType>> GetBillTypeAsync(); 
    }
}
