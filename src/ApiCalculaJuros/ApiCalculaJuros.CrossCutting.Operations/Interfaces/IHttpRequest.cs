using System.Threading.Tasks;

namespace ApiCalculaJuros.CrossCutting.Operations.Interfaces
{
    public interface IHttpRequest
    {
        Task<double> getTaxaJuros();
    }
}
