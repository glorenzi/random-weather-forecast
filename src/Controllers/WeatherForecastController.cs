using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("random")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Forecasts = new[]
        {
            "Sunny",
            "Partly sunny",
            "Partly cloudy",
            "Rainy",
            "Snowy",
            "Cloudy",
            "Windy"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new WeatherForecast { Condition = Forecasts[Random.Shared.Next(Forecasts.Length)] });
        }
    }
}