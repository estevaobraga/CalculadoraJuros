using ApiCalculaJuros.WebApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ApiCalculaJuros.TestIntegracao
{
    public class ShowmethecodeControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ShowmethecodeControllerIntegrationTests(WebApplicationFactory<Startup> Factory)
        {
            _client = Factory.CreateClient();
        }

        [Fact]
        public async Task GetShowmethecode()
        {
            var httpResponse = await _client.GetAsync("/showmethecode");

            httpResponse.EnsureSuccessStatusCode();

            var stringResponse = await httpResponse.Content.ReadAsStringAsync();

            Assert.Contains("https://github.com/estevaobraga/CalculadoraJuros", stringResponse);
        }
    }
}
