using System.Threading.Tasks;
using ApiTaxaJuros.Domain.Interfaces;
using ApiTaxaJuros.Domain.Models;

namespace ApiTaxaJuros.Data
{
    public class TaxaJurosRepositorio : ITaxaJurosRepositorio
    {
        public async Task<Juros> consultarTaxaDeJuros()
        {
            return new Juros { taxa = 0.01 };
        }
    }
}
