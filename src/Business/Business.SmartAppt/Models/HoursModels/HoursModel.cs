namespace Business.SmartAppt.Models.HoursModels;

public class HoursModel
{
    public int OpeningHoursId { get; set; }
    public int BusinessId { get; set; }
    public byte DayOfWeek { get; set; }
    public TimeSpan OpenTime { get; set; }
    public TimeSpan CloseTime { get; set; }
}