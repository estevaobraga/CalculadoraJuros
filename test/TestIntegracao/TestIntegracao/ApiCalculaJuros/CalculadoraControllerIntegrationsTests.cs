using ApiCalculaJuros.WebApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestIntegracao.ApiCalculaJuros
{
    public class CalculadoraControllerIntegrationsTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public CalculadoraControllerIntegrationsTests(WebApplicationFactory<Startup> Factory)
        {
            _client = Factory.CreateClient();
        }

        [Fact]
        public async Task calculajuros()
        {
            var httpResponse = await _client.GetAsync("/calculajuros100&5");

            httpResponse.EnsureSuccessStatusCode();

            var stringResponse = await httpResponse.Content.ReadAsStringAsync();

            Assert.Contains("105.10", stringResponse);
        }
    }
}
