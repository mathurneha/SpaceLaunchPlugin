using Microsoft.AspNetCore.Mvc;

namespace SpacePlugin.Controllers;

[ApiController]
[Route("[controller]")]
public class SpacePluginController : ControllerBase
{
    private readonly ILogger<SpacePluginController> _logger;

    public SpacePluginController(ILogger<SpacePluginController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSpaceLaunchInfo")]
    public SpacePlugin Get()
    {
        var launch = new SpacePlugin()
        {
            DateUtc = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
            FlightNumber = 111,
            WebcastLink = "test link"
        };

        return launch;
    }
}