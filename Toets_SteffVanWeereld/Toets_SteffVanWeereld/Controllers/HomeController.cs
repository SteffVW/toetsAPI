using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toets_SteffVanWeereld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _config;

        public HomeController(IHostEnvironment env, IConfiguration config)
        {
            _env = env;
            _config = config;
        }

        [HttpGet]
        public IActionResult GetEnvironmentMessage()
        {
            var environmentMessage = _config["AppSettings:EnvironmentMessage"];

            if (_env.IsDevelopment())
            {
                return Ok(environmentMessage);
            }
            else if (_env.IsProduction())
            {
                return Ok(environmentMessage);
            }
            else if (_env.IsStaging())
            {
                return Ok(environmentMessage);
            }
            else
            {
                return Ok("Not found");
            }
        }
    }
}

