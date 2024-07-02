using System.Collections.Generic;
using System.Linq;

namespace SampleGraphQL
{
    public class Query
    {
        private readonly WeatherForecastService _weatherForecastService;

        public Query(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        public async Task<IQueryable<WeatherForecast>> GetWeatherForecastsAsync()
        {
            var forecasts = await _weatherForecastService.GetForecastsAsync();
            return forecasts.AsQueryable();
        }
    }
}
