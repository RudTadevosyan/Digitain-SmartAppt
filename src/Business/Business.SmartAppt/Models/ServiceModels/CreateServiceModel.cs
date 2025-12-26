namespace Business.SmartAppt.Models.ServiceModels
{
    public class CreateServiceModel
    {
        public string Name { get; set; } = null!;
        public int DurationMin { get; set; }
        public Decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
