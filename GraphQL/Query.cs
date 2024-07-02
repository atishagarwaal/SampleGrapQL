﻿using SampleGrapQL;
using System.Collections.Generic;
using System.Linq;

namespace SampleGraphQL
{
    public class Query
    {
        private readonly WeatherForecastService _weatherForecastService;
        private readonly NewsService _newsService;

        public Query(WeatherForecastService weatherForecastService, NewsService newsService)
        {
            _weatherForecastService = weatherForecastService;
            _newsService = newsService;
        }

        public async Task<IQueryable<WeatherForecast>> GetWeatherForecastsAsync()
        {
            var forecasts = await _weatherForecastService.GetForecastsAsync();
            return forecasts.AsQueryable();
        }

        public async Task<IQueryable<NewsArticle>> GetNewsAsync()
        {
            var forecasts = await _newsService.GetNewsAsync();
            return forecasts.AsQueryable();
        }
    }
}
