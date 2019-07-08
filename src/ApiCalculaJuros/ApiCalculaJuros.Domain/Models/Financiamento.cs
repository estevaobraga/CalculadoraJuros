using System;

namespace ApiCalculaJuros.Domain.Models
{
    public class Financiamento
    {
        public double valorInicial { get; set; }
        public double valorJuros { get; set; }
        public int tempo { get; set; }

        public double ValorFinal
        {
            get
            {
                var calc = Math.Truncate((valorInicial * Math.Pow(1 + valorJuros, tempo))*100)/100;
                return calc;
            }
        }

    }
}
