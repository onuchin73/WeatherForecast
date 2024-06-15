using WeatherForecasts.Domain.Abstractions;
using WeatherForecasts.Domain.Models;

namespace WeatherForecasts.Services
{
    public class WeatherForecastService(IWeatherForecastRepository repo) : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repo = repo;

        public List<WeatherForecast> ProcessFTemperature()
        {
            var forecasts = _repo.GetForecasts();

            var processed = new List<WeatherForecast>();
            foreach (var f in forecasts)
            {
                f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
                processed.Add(f);
            }

            return processed;
        }
    }
}
