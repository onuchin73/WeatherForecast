using Microsoft.AspNetCore.Mvc;
using WeatherForecasts.Domain.Abstractions;
using WeatherForecasts.Domain.Models;

namespace WeatherForecasts.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(IWeatherForecastService service) : ControllerBase
    {
        private readonly IWeatherForecastService _service = service;

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.ProcessFTemperature();
        }
    }
}
