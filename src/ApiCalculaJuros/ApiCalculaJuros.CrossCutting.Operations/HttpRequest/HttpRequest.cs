using ApiCalculaJuros.CrossCutting.Operations.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiCalculaJuros.CrossCutting.Operations.HttpRequest
{
    public class HttpRequest : IHttpRequest
    {

        public async Task<double> getTaxaJuros()
        {
            dynamic taxa;
            var client = new HttpClient();
            var response = await client.GetAsync("http://apitaxajuros/taxaJuros");

            if (response.IsSuccessStatusCode)
            {
                taxa = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
            }
            else
                throw new System.Exception("Erro na requisição da taxa");

            return taxa.taxa;
        }

    }
}
