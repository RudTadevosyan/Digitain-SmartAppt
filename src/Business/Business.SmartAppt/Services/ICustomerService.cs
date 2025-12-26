using Business.SmartAppt.Models;
using Business.SmartAppt.Models.BookingModels;

namespace Business.SmartAppt.Services
{
    public interface ICustomerService
    {
        Task<BaseResponse<IEnumerable<BookingModel>>> GetMyBookingsAsync(int customerId, int pageNumber = 1, int pageSize = 10);
        Task<BaseResponse<BookingModel>> CreateBookingAsync(int customerId, CreateBookingModel booking);
        Task<BaseResponse<bool>> UpdateBookingAsync(int customerId, int bookingId, UpdateBookingModel booking);
        Task<BaseResponse<bool>> CancelBookingAsync(int customerId, int bookingId);
        Task<BaseResponse<bool>> DeleteBookingAsync(int customerId, int bookingId);
        Task<BaseResponse<CalendarModel>> GetMonthlyCalendar(int businessId, int serviceId, int month, int year);
        Task<BaseResponse<DailySlotsModel>> GetDailyFreeSlots(int businessId, int serviceId, DateOnly date);

    }
}
