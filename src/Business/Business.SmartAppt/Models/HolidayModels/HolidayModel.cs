namespace Business.SmartAppt.Models.HolidayModels;

public class HolidayModel
{
    public int HolidayId { get; set; }
    public int BusinessId { get; set; }
    public DateTime HolidayDate {  get; set; }
    public string? Reason { get; set; }
}