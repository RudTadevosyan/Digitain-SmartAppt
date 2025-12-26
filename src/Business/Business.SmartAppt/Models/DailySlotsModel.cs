namespace Business.SmartAppt.Models
{
    public class DailySlotsModel
    {
        public DateOnly Date { get; set; }
        public List<TimeSpan> FreeSlots { get; set; } = new List<TimeSpan>();
    }
}
