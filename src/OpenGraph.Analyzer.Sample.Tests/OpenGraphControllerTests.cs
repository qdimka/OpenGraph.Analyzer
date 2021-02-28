using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace OpenGraph.Analyzer.Sample.Tests
{
    public class OpenGraphControllerTests: IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public OpenGraphControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("api/opengraph");
            
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}