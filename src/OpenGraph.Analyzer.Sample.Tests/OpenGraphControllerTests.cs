using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace OpenGraph.Analyzer.Sample.Tests
{
    public class OpenGraphControllerTests: IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly ITestOutputHelper _outputHelper;

        public OpenGraphControllerTests(WebApplicationFactory<Startup> factory, 
            ITestOutputHelper outputHelper)
        {
            _factory = factory;
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData("https://sonarcloud.io/")]
        [InlineData("https://www.deepl.com/")]
        [InlineData("https://calendar.google.com/")]
        [InlineData("https://www.imdb.com/")]
        [InlineData("https://borovichi.sdelkino.com/")]
        public async Task Get(string url)
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync($"api/opengraph?url={url}");
            var responseString = await response.Content.ReadAsStringAsync();
            
            _outputHelper.WriteLine(responseString);
            
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}