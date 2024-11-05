namespace Toets_SteffVanWeereld.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int VacationHomeId { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }
    }
}
