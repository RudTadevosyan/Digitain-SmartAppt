namespace Business.SmartAppt.Models.BookingModels
{
    public class CreateBookingModel
    {
        public int BusinessId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartAtUtc { get; set; }
        public string Status { get; private set; } = "Pending";
        public string? Notes { get; set; }
    }
}
