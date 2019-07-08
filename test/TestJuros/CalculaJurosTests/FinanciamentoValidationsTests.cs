using Xunit;
using ApiCalculaJuros.Domain.Validations;
using ApiCalculaJuros.Domain.Models;

namespace CalculaJurosTests
{
    public class FinanciamentoValidationsTests
    {
        private readonly FinanciamentoValidations Validation;

        public FinanciamentoValidationsTests()
        {
            Validation = new FinanciamentoValidations();
        }

        [Theory]
        [InlineData(100, 5, true)]
        [InlineData(0, 0, false)]
        [InlineData(100, 0, false)]
        [InlineData(-1, 0, false)]
        [InlineData(-1, 1, false)]
        [InlineData(-1, -1, false)]
        public void FinanciamentoValidation(double valorInicial, int meses, bool resultadoEsperado)
        {
            var financiamento = new Financiamento { valorInicial = valorInicial, tempo = meses };

            var result = Validation.Validate(financiamento);
            
            Assert.Equal(resultadoEsperado, result.IsValid);
        }
    }
}
