using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkyRouteLogistics.Models;

namespace SkyRouteLogistics.Controllers
{
    [ApiController]
    [Route("api/flights")] // Angular bu adrese istek atacak
    public class FlightsApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FlightsApiController(AppDbContext context)
        {
            _context = context;
        }

        // Dış dünyaya JSON formatında uçuş listesini fırlatan API ucu
        [HttpGet]
        public IActionResult GetFlights()
        {
            var flights = _context.Flights.ToList();
            return Ok(flights); // 200 OK koduyla veriyi JSON olarak döner
        }
    }
}