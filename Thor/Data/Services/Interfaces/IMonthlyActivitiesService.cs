using Thor.Data.Models;

namespace Thor.Data.Services.Interfaces
{
    public interface IMonthlyActivitiesService
    { 
        Task<List<MonthlyActivities>> GetMonthlyActivitiesAsync();
    }
}
