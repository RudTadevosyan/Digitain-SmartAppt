using Business.SmartAppt.Models;
using Business.SmartAppt.Models.BookingModels;
using Business.SmartAppt.Services;
using Microsoft.AspNetCore.Mvc;

namespace SmartAppt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        
        [HttpPost("{customerId}/bookings")]
        public async Task<IActionResult> CreateBooking(int customerId, [FromBody] CreateBookingModel model)
        {
            var result = await _customerService.CreateBookingAsync(customerId, model);
            return StatusCode(result.HttpStatusCode, result);
        }

        [HttpPut("{customerId}/bookings/{bookingId}")]
        public async Task<IActionResult> UpdateBooking(int customerId, int bookingId, [FromBody] UpdateBookingModel model)
        {
            var result = await _customerService.UpdateBookingAsync(customerId, bookingId, model);
            return StatusCode(result.HttpStatusCode, result);
        }

        [HttpDelete("{customerId}/bookings/{bookingId}")]
        public async Task<IActionResult> DeleteBooking(int customerId, int bookingId)
        {
            var result = await _customerService.DeleteBookingAsync(customerId, bookingId);
            return StatusCode(result.HttpStatusCode, result);
        }

        [HttpPost("{customerId}/bookings/{bookingId}/cancel")]
        public async Task<IActionResult> CancelBooking(int customerId, int bookingId)
        {
            var result = await _customerService.CancelBookingAsync(customerId, bookingId);
            return StatusCode(result.HttpStatusCode, result);
        }

        [HttpGet("{customerId}/bookings")]
        public async Task<IActionResult> GetMyBookings(int customerId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var result = await _customerService.GetMyBookingsAsync(customerId, pageNumber, pageSize);
            return StatusCode(result.HttpStatusCode, result);
        }
        
        [HttpGet("/api/businesses/{businessId}/services/{serviceId}/calendar/{year}/{month}/{day}/slots")]
        public async Task<IActionResult> GetDailyFreeSlots(int businessId, int serviceId, int year, int month, int day)
        {
            var date = new DateOnly(year, month, day);
            var result = await _customerService.GetDailyFreeSlots(businessId, serviceId, date);
            return StatusCode(result.HttpStatusCode, result);
        }

        [HttpGet("/api/businesses/{businessId}/services/{serviceId}/calendar/{year}/{month}")]
        public async Task<IActionResult> GetMonthlyCalendar(int businessId, int serviceId, int year, int month)
        {
            var result = await _customerService.GetMonthlyCalendar(businessId, serviceId, month, year);
            return StatusCode(result.HttpStatusCode, result);
        }
    }
}
