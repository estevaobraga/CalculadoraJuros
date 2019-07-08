using ApiTaxaJuros.Data;
using ApiTaxaJuros.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTaxaJuros.CrossCutting.IoC
{
    public class Injetor
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosRepositorio, TaxaJurosRepositorio>();
        }
    }
}
