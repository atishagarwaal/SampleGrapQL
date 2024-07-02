using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleGraphQL
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing"
        };

        public IEnumerable<WeatherForecast> GetForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 2).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastsAsync()
        {
            var rng = new Random();
            var result = await Task.Run(() => Enumerable.Range(1, 2).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray());

            return result;
        }
    }
}
