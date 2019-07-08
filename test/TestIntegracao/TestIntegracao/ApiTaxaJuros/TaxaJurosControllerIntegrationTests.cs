using ApiTaxaJuros.WebApi;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestIntegracao.ApiTaxaJuros
{
    public class TaxaJurosControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public TaxaJurosControllerIntegrationTests(WebApplicationFactory<Startup> Factory)
        {
            _client = Factory
                .WithWebHostBuilder(builder => builder.UseSolutionRelativeContentRoot("../../src/ApiTaxaJuros/ApiTaxaJuros.WebApi"))
                .CreateClient();
        }

        [Fact]
        public async Task GetTaxaJuros()
        {
            var httpResponse = await _client.GetAsync("/taxaJuros");

            httpResponse.EnsureSuccessStatusCode();
            
            Assert.True(httpResponse.IsSuccessStatusCode);
        }
    }
}
