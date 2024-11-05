using Microsoft.AspNetCore.Mvc;
using Toets_SteffVanWeereld.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toets_SteffVanWeereld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;
        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        [HttpPost("book")]
        public IActionResult Book(Booking booking)
        {
            _logger.LogInformation("Received booking request | User ID: {UserId} | Booking Time: {BookingTime}",1 , booking.StartDate);

            return Ok("Booking logged");
        }
        [HttpPost("cancel")]
        public IActionResult Cancel(Booking booking)
        {
            _logger.LogInformation("Received cancellation request | User ID: {UserId} | Booking ID: {BookingId}", 1, booking.Id);

            return Ok("Cancellation logged");
        }
        [HttpPost("modify")]
        public IActionResult Modify(Booking booking)
        {
            _logger.LogInformation("Received modification request | User ID: {UserId} | Booking ID: {BookingId} | New Booking Time: {NewBookingTime}", 1, booking.Id, booking.StartDate);

            return Ok("Modification logged.");
        }
    }
}
