using System.Threading.Tasks;
using ApiCalculaJuros.Domain.Models;

namespace ApiCalculaJuros.Domain.Interfaces
{
    public interface IFinanciamentoServices
    {
        Task<double> retornaValorJuros(Financiamento financiamento);
    }
}
