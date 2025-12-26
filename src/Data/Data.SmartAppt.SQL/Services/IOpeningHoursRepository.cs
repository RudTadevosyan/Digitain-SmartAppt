using Data.SmartAppt.SQL.Models;


namespace Data.SmartAppt.SQL.Services
{
    public interface IOpeningHoursRepository
    {
        Task<IEnumerable<OpeningHoursEntity>> GetAllAsync(int pageNumber = 1, int pageSize = 10);
        Task<OpeningHoursEntity?> GetByBusinessIdAndDowAsync(int businessId, byte dayOfWeek);
        Task<IEnumerable<OpeningHoursEntity>> GetByBusinessIdAsync(int businessId);
        Task<int> CreateAsync(OpeningHoursEntity entity);
        Task UpdateAsync(OpeningHoursEntity entity);
        Task DeleteAsync(int hoursId);
    }
}
