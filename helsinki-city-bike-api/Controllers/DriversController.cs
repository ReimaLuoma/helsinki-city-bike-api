using BikeApp.Data;
using BikeApp.Drivers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace helsinki_city_bike_api.Controllers;

[ApiController]
[Route("[controller]")]
public class DriversController : ControllerBase
{

    private readonly ILogger<DriversController> _logger;
    private readonly ApiDbContext _context;

    public DriversController(ILogger<DriversController> logger, ApiDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "AllJourneys")]
    public async Task<IActionResult> Get() {
        var driver = new Driver() {
            Id = 1,
            Departure = "2021-05-31T23:57:25",
            Return = "2021-06-01T00:05:46",
            DepartureStationId = 094,
            DepartureStationName = "Laajalahden aukio",
            ReturnStationId = 100,
            ReturnStationName = "Teljäntie",
            CoveredDistance = 2043,
            Duration = 500
        };

        _context.Add(driver);
        await _context.SaveChangesAsync();

        var allDrivers = await _context.Drives.ToListAsync();

        return Ok(allDrivers);

    }
}
