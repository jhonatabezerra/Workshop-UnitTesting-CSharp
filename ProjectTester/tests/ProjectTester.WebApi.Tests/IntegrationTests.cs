using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTester.WebApi.Tests
{
    public class IntegrationTests : WebApplicationFactory<Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            // shared extra set up goes here
            return base.CreateHost(builder);

            
        }

        [Fact]
        public async Task Test()
        {
            var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    // set up servises
                });
            });
            var client = application.CreateClient();
            var response = await client.GetStringAsync("/api/WeatherForecast");

            // Assert
        }
    }
}