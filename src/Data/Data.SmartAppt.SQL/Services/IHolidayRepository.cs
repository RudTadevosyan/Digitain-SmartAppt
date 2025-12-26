using Data.SmartAppt.SQL.Models;


namespace Data.SmartAppt.SQL.Services
{
    public interface IHolidayRepository
    {
        Task<IEnumerable<HolidayEntity>> GetAllAsync(int pageNumber = 1, int pageSize = 10);
        Task<HolidayEntity?> GetByBusinessIdAsync(int businessId, DateTime date);
        Task<HolidayEntity?> GetByIdAsync(int holidayId);
        Task<int> CreateAsync(HolidayEntity entity);
        Task UpdateAsync(HolidayEntity entity);
        Task DeleteAsync(int holidayId);
        Task<List<HolidayEntity>> GetAllByMonthAsync(int businessId, int year, int month);
    }
}
