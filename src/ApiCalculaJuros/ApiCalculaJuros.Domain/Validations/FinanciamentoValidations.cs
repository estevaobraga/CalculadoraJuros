using ApiCalculaJuros.Domain.Models;
using FluentValidation;

namespace ApiCalculaJuros.Domain.Validations
{
    public class FinanciamentoValidations : AbstractValidator<Financiamento>
    {
        public FinanciamentoValidations()
        {
            RuleFor(x => x.valorInicial)
                .NotEqual(0)
                .WithMessage("Por favor, informe o valor inicial do financiamento")
                .Must((f, v) => v < 0d ? false : true)
                .WithMessage("Por favor, informe um valor inicial positivo");

            RuleFor(x => x.tempo)
                .NotEqual(0)
                .WithMessage("Por favor, informe a quantidade de meses do financiamento")
                .Must((f, t) => t < 0 ? false : true);
        }
    }
}
