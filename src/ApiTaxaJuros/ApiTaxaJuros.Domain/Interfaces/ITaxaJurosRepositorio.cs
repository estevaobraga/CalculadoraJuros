using ApiTaxaJuros.Domain.Models;
using System.Threading.Tasks;

namespace ApiTaxaJuros.Domain.Interfaces
{
    public interface ITaxaJurosRepositorio
    {
        Task<Juros> consultarTaxaDeJuros();
    }
}
