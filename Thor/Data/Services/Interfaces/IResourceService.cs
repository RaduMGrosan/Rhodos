using Thor.Data.Models;

namespace Thor.Data.Services.Interfaces
{
    public interface IResourceService
    {
        Task<Resource[]> GetResourcesAsync(); 
    } 
}
