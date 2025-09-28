using Desafio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Domain.Entities
{
    public class Titulo:Entity
    {
        public string NumeroTitulo {  get; set; }
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
