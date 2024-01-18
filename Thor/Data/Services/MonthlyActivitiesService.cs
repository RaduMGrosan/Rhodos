using Thor.Data.Models;
using Thor.Data.Services.Interfaces;

namespace Thor.Data.Services
{
    public class MonthlyActivitiesService : IMonthlyActivities
    {
        private readonly List<MonthlyActivities> list = new List<MonthlyActivities>() { 
        
        };

        public Task<List<MonthlyActivities>> GetMonthlyActivitiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
