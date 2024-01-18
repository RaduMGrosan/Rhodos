using Thor.Data.Models;

namespace Thor.Data.Services.Interfaces
{
    public interface IMonthlyActivities
    {
        Task<List<MonthlyActivities>> GetMonthlyActivitiesAsync();
    }
}
