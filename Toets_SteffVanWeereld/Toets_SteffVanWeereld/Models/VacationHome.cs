namespace Toets_SteffVanWeereld.Models
{
    public class VacationHome
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;    
        public decimal PricePerNight { get; set; }
        public int MaxGuests { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime AvailableEndDate { get; set; }
        public DateTime AvailableStartDate { get; set; }
    }
}
