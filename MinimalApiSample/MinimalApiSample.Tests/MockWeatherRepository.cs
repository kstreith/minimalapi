namespace MinimalApiSample.Tests
{
    public class MockWeatherRepository : IWeatherRepository
    {
        public IEnumerable<WeatherForecast> GetForecast()
        {
            return new List<WeatherForecast> {
                new WeatherForecast(
                    new DateTime(2022, 1, 13, 4, 12, 22),
                    12,
                    "fake")
            };
        }
    }
}
