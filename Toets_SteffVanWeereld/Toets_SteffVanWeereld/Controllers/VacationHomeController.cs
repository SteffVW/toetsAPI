using Microsoft.AspNetCore.Mvc;
using Toets_SteffVanWeereld.Models;
using Toets_SteffVanWeereld.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toets_SteffVanWeereld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationHomeController : ControllerBase
    {
        private readonly IVacationHomeService _vacationHomeService;

        public VacationHomeController(IVacationHomeService vacationHomeService)
        {
            _vacationHomeService = vacationHomeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<VacationHome>>> GetAll()
        {
            var allHomes = await _vacationHomeService.GetAll();

            return Ok(allHomes);
        }
        [HttpGet("{id}/details")]
        public async Task<ActionResult<VacationHome>> GetDetailsById(int id)
        {
            var home = await _vacationHomeService.GetDetailsById(id);
            if (home == null)
            {
                return NotFound($"Vacation home with ID {id} not found.");
            }

            return Ok(home);
        }
        [HttpGet("search")]
        public async Task<ActionResult<List<VacationHome>>> Search([FromQuery] string location, [FromQuery] DateTime start, [FromQuery] DateTime end)
        {
            var homes = await _vacationHomeService.SearchAvailableByPlace(location, start, end);
            if(homes == null)
            {
                return NotFound($"No vacation homes available in {location} from {start} to {end}.");
            }

            return Ok(homes);
        }
    }
}
