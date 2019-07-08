using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ApiCalculaJuros.WebApi.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        /// <summary>
        /// Retorna "status code" 400 com a lista de erros de validação
        /// </summary>
        /// <param name="validation"></param>
        /// <returns></returns>
        protected BadRequestObjectResult BadRequest(ValidationResult validation)
        {
            return BadRequest(validation.Errors.Select(x => new { x.PropertyName, x.ErrorMessage }));
        }
    }
}