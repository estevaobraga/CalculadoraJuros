using ApiCalculaJuros.CrossCutting.Operations.HttpRequest;
using ApiCalculaJuros.CrossCutting.Operations.Interfaces;
using ApiCalculaJuros.Domain.Interfaces;
using ApiCalculaJuros.Domain.Validations;
using ApiCalculaJuros.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCalculaJuros.CrossCutting.IoC
{
    public class Injetor
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            #region services
            services.AddTransient<IFinanciamentoServices, FinanciamentoServices>();
            services.AddTransient<IHttpRequest, HttpRequest>();
            #endregion

            #region Validations
            services.AddScoped<FinanciamentoValidations>();
            #endregion
        }
    }
}
