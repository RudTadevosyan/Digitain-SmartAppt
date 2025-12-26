namespace Business.SmartAppt.Models.HoursModels
{
    public class CreateHoursModel
    {
        public byte DayOfWeek { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
    }
}
