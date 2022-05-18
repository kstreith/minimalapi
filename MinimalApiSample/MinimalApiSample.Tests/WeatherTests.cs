using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Text;
using Xunit;

namespace MinimalApiSample.Tests
{
    public class WeatherTests
    {
        //[Fact]
        //public async Task Get_Forecast_Returns_Values()
        //{
        //    var application = new WebApplicationFactory<Program>();
        //    var client = application.CreateClient();
        //    var data = await client.GetFromJsonAsync<List<WeatherForecast>>("/weatherforecast");

        //    data.Should().HaveCount(5);
        //}

        [Fact]
        public async Task Get_ForecastFromRepo_Returns_Values()
        {
            var application = new TestApplication();
            var client = application.CreateClient();
            var data = await client.GetFromJsonAsync<List<WeatherForecast>>("/repo-weatherforecast");

            data.Should().HaveCount(1);
            data[0].Summary.Should().Be("fake");
            data[0].TemperatureC.Should().Be(12);
            data[0].TemperatureF.Should().Be(53);

        }

        [Fact]
        public async Task Post_Forecast_Returns_Values()
        {
            var application = new TestApplication();
            var client = application.CreateClient();
            var content = new StringContent("{\"Temperature\":3}", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/forecast", content);
            var responseStr = await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }

    }
}
