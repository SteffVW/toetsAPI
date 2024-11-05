using Toets_SteffVanWeereld.Models;

namespace Toets_SteffVanWeereld.Services
{
    public interface IVacationHomeService
    {
        Task<List<VacationHome>> GetAll();
        Task<VacationHome> GetDetailsById(int id);
        Task<List<VacationHome>> SearchAvailableByPlace(string location, DateTime start, DateTime end);
    }
}