using Microsoft.AspNetCore.Mvc;

namespace MinimalApiSample
{
    public static class WeatherForecastRoutes
    {
        public static void ConfigureRoutes(this WebApplication app)
        {
            app.MapGet("/repo-weatherforecast", (IWeatherRepository weatherRepository) =>
            {
                return weatherRepository.GetForecast();
            })
            .WithName("GetRepoWeatherForecast");
            app.MapPost("/forecast", (WeatherInput input) =>
            {
                return input;
            });
        }
    }
}
