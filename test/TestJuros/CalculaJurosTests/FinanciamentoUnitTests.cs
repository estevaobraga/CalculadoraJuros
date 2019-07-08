using ApiCalculaJuros.Domain.Models;
using Xunit;

namespace CalculaJurosTests
{
    public class FinanciamentoUnitTests
    {
        public FinanciamentoUnitTests()
        {

        }

        [Theory]
        [InlineData(100, 5, 0.01, 105.10)]
        [InlineData(101, 5, 0.01, 106.15)]
        [InlineData(371, 12, 0.01, 418.05)]
        [InlineData(100, 0, 0.01, 100)]
        public void ValorFinalTest(double valorInicial, int meses, double juros, double resultadoEsperado)
        {
            var dadosFinanciamento = new Financiamento { valorInicial = valorInicial, tempo = meses, valorJuros = juros };

            Assert.Equal(resultadoEsperado, dadosFinanciamento.ValorFinal);
        }
    }
}
