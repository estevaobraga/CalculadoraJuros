using ApiCalculaJuros.Domain.Interfaces;
using ApiCalculaJuros.Domain.Models;
using ApiCalculaJuros.Domain.Validations;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;

namespace ApiCalculaJuros.WebApi.Controllers
{
    public class CalculadoraController : BaseController
    {
        public CalculadoraController()
        {
        }

        /// <summary>
        /// Retorna o valor final do financiamento
        /// </summary>
        /// <remarks>
        /// Requisição:
        ///
        ///     GET /calculajuros
        ///     {
        ///        "valorFinal": 105,10
        ///     }
        ///     
        /// </remarks>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("calculajuros{valorinicial}&{meses}")]
        [SwaggerResponse(200, "Sucess")]
        [SwaggerResponse(400, "BadRequest")]
        [SwaggerResponse(500, "Internal Server Error")]
        public async Task<IActionResult> Get([FromServices] IFinanciamentoServices financiamento,
            [FromServices] FinanciamentoValidations validation,
            double valorinicial, int meses)
        {
            var dadosFinanciamento = new Financiamento { valorInicial = valorinicial, tempo = meses };

            var isValid = await validation.ValidateAsync(dadosFinanciamento);
            if (!isValid.IsValid)
                return BadRequest(isValid);

            return Ok((await financiamento.retornaValorJuros(dadosFinanciamento)).ToString("N2"));
        }
    }
}