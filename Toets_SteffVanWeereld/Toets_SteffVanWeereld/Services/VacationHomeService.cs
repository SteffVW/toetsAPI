using Toets_SteffVanWeereld.Models;

namespace Toets_SteffVanWeereld.Services
{
    public class VacationHomeService : IVacationHomeService
    {
        private static readonly List<VacationHome> vacationHomes = new List<VacationHome>
        {
            new VacationHome
            {
                Id = 1,
                Name = "Seaside Cottage",
                Location = "Beachfront, Malibu",
                PricePerNight = 250.00m,
                MaxGuests = 4,
                IsAvailable = true,
                AvailableStartDate = new DateTime(2024, 11, 1),
                AvailableEndDate = new DateTime(2024, 11, 30)
            },
            new VacationHome
            {
                Id = 2,
                Name = "Mountain Retreat",
                Location = "Aspen, Colorado",
                PricePerNight = 300.00m,
                MaxGuests = 6,
                IsAvailable = false,
                AvailableStartDate = new DateTime(2024, 12, 1),
                AvailableEndDate = new DateTime(2024, 12, 15)
            },
            new VacationHome
            {
                Id = 3,
                Name = "Urban Apartment",
                Location = "Downtown, New York City",
                PricePerNight = 180.00m,
                MaxGuests = 2,
                IsAvailable = true,
                AvailableStartDate = new DateTime(2024, 11, 5),
                AvailableEndDate = new DateTime(2024, 11, 15)
            },
            new VacationHome
            {
                Id = 4,
                Name = "Lake House",
                Location = "Lake Tahoe, California",
                PricePerNight = 400.00m,
                MaxGuests = 8,
                IsAvailable = false,
                AvailableStartDate = new DateTime(2024, 12, 20),
                AvailableEndDate = new DateTime(2025, 1, 5)
            },
            new VacationHome
            {
                Id = 5,
                Name = "Countryside Villa",
                Location = "Tuscany, Italy",
                PricePerNight = 350.00m,
                MaxGuests = 5,
                IsAvailable = true,
                AvailableStartDate = new DateTime(2024, 11, 10),
                AvailableEndDate = new DateTime(2024, 11, 20)
            }
            };


        public Task<List<VacationHome>> GetAll()
        {
            return Task.FromResult(vacationHomes);
        }

        public Task<VacationHome> GetDetailsById(int id)
        {
            var homeToGet = vacationHomes.FirstOrDefault(x => x.Id == id);

            return Task.FromResult(homeToGet);
        }

        public Task<List<VacationHome>> SearchAvailableByPlace(string location, DateTime start, DateTime end)
        {
            var availableHomes = vacationHomes.Where(x => x.Location.Equals(location, StringComparison.OrdinalIgnoreCase) && x.IsAvailable && x.AvailableStartDate <= end && x.AvailableEndDate >= start).ToList();

            return Task.FromResult(availableHomes);
        }
    }
}
