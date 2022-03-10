using Microsoft.AspNetCore.Mvc;
using ProjectTester_Services;

namespace ProjectTester.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) => _logger = logger;

        [HttpGet(Name = "GetWeatherForecast")]
        public string[] Get() => new WeatherForecastProvider().GetWeatherForecast();
    }
}