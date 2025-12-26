using Data.SmartAppt.SQL.Models;

namespace Data.SmartAppt.SQL.Services
{
    public interface IServiceRepository
    {
        Task<int> CreateAsync(ServiceEntity service);
        Task<ServiceEntity?> GetByIdAsync(int serviceId);
        Task<IEnumerable<ServiceEntity>> GetAllAsync(int pageNumber = 1, int pageSize = 10);
        Task<IEnumerable<ServiceEntity>> GetByBusinessIdAsync(int businessId);
        Task UpdateAsync(ServiceEntity service);
        Task DeleteAsync(int serviceId);
        Task DeactivateAsync(int serviceId);
        Task ActivateAsync(int serviceId);
    }
}
