using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTester.WebApi.Tests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public IntegrationTests(WebApplicationFactory<Startup> factory) => _factory = factory;

        [Fact]
        public async Task GetAsync_WhenCallSwaggerPage_ShouldReturnHttp200()
        {
            // Arrange
            const string path = "/swagger/index.html";
            HttpClient client = _factory.CreateClient();

            // Act
            HttpResponseMessage response = await client.GetAsync(path);
            string context = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.NotEmpty(context);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}