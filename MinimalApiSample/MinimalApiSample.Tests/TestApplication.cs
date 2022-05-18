using Microsoft.AspNetCore.Mvc.Testing;

namespace MinimalApiSample.Tests
{
    public class TestApplication : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {

            });
        }
    }
}
