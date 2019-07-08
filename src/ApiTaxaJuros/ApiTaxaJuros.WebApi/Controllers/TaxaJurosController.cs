using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTaxaJuros.Domain.Interfaces;

namespace ApiTaxaJuros.WebApi.Controllers
{
    public class TaxaJurosController : Controller
    {
        public TaxaJurosController()
        {

        }

        /// <summary>
        /// Retorna a taxa de juros
        /// </summary>
        /// <remarks>
        /// Requisição:
        ///
        ///     GET /taxaJuros
        ///     {
        ///        "taxa": 0.01,
        ///     }
        ///     
        /// </remarks>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("taxaJuros")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get([FromServices] ITaxaJurosRepositorio juros)
        {
            return Ok(await juros.consultarTaxaDeJuros());
        }
    }
}