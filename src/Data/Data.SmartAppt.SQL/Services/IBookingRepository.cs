using Data.SmartAppt.SQL.Models;

namespace Data.SmartAppt.SQL.Services
{
    public interface IBookingRepository
    {
        Task<IEnumerable<BookingEntity>> GetAllAsync(int pageNumber = 1, int pageSize = 10);
        Task<IEnumerable<BookingEntity>> GetAllSpecAsync(BookingFilter filter); 
        Task<BookingEntity?> GetByIdAsync(int bookingId);
        Task<int> CreateAsync(BookingEntity entity);
        Task UpdateAsync(BookingEntity entity);
        Task DeleteAsync(int bookingId);
        Task CancelAsync(int bookingId);
        Task ChangeBookingStatusAsync(int bookingId, string status);
        Task<IEnumerable<BookingEntity>> GetBookingsByRangeAsync(int businessId, DateTime from, DateTime to, int pageNumber = 1, int pageSize = 10);
        Task<Dictionary<DateOnly, int>> GetBookingsCountByBusinessAndRangeAsync(int businessId, int serviceId, DateOnly startDate, DateOnly endDate);
    }
}
