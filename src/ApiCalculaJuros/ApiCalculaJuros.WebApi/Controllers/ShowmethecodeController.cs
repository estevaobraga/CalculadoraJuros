using Microsoft.AspNetCore.Mvc;

namespace ApiCalculaJuros.WebApi.Controllers
{
    [Route("[controller]")]
    public class ShowmethecodeController : Controller
    {
        public ShowmethecodeController() { }

        /// <summary>
        /// Retornar a url de onde encontra-se o fonte no github
        /// </summary>
        /// <remarks>
        /// Requisição:
        ///
        ///     GET /showmethecode
        ///     {
        ///        "https://github.com/estevaobraga"
        ///     }
        ///     
        /// </remarks>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("https://github.com/estevaobraga/CalculadoraJuros");
        }
    }
}