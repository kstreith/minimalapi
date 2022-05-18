public interface IWeatherRepository
{
    IEnumerable<WeatherForecast> GetForecast();
}