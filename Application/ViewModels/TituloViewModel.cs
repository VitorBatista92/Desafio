using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Application.ViewModels
{
    public class TituloViewModel
    {
        public Guid Id { get; set; }
        public string NumeroTitulo { get; set; }
        public string NomeDevedor { get; set; }
        public string CPFDevedor { get; set; }
        public int PorcentagemJuros { get; set; }
        public int PorcentagemMulta { get; set; }
        public int ParcelaDivida { get; set; }
        public int NumeroDaParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public int ValorDaParcela { get; set; }
    }
}
