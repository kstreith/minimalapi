using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace MinimalApiSample.Tests
{
    public class WeatherTests
    {
        [Fact]
        public async Task Get_Forecast_Returns_Values()
        {
            var application = new TestApplication();
            var client = application.CreateClient();
            var data = await client.GetFromJsonAsync<List<WeatherForecast>>("/weatherforecast");

            data.Should().HaveCount(5);
        }
    }
}
