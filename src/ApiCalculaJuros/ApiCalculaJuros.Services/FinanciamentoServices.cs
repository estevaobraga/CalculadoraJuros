using System.Threading.Tasks;
using ApiCalculaJuros.CrossCutting.Operations.Interfaces;
using ApiCalculaJuros.Domain.Interfaces;
using ApiCalculaJuros.Domain.Models;

namespace ApiCalculaJuros.Services
{
    public class FinanciamentoServices : IFinanciamentoServices
    {
        private readonly IHttpRequest _request;

        public FinanciamentoServices(IHttpRequest request)
        {
            _request = request;
        }

        public async Task<double> retornaValorJuros(Financiamento financiamento)
        {
            financiamento.valorJuros = await _request.getTaxaJuros();

            return financiamento.ValorFinal;
        }
    }
}
