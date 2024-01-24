using Thor.Data.Models;

namespace Thor.Data.Services.Interfaces
{
    public interface IReminderService
    {
        Task<Reminder[]> GetRemindersAsync(); 
    }
}
