using Thor.Data.Models;
using Thor.Data.Services.Interfaces;

namespace Thor.Data.Services.Implementations
{
    public class MonthlyActivitiesService : IMonthlyActivitiesService
    {
        private readonly List<MonthlyActivities> list = new List<MonthlyActivities>()
        {

        };

        public Task<List<MonthlyActivities>> GetMonthlyActivitiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
