namespace Business.SmartAppt.Models
{
    public class CalendarModel 
    {
        public int Month {  get; set; }
        public int Year { get; set; }
        public List<DayAvailability> Days { get; set; } = new List<DayAvailability>();
    }
}
