using Desafio.Application.ViewModels;
using Desafio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Application.Extensions
{
    public static class TituloExtensions
    {
        public static TituloViewModel ToViewModel(Titulo titulo)
        {
            if (titulo == null) return null;
            return  new TituloViewModel
            {
                Id = titulo.Id,
                NumeroTitulo = titulo.NumeroTitulo,
                NomeDevedor = titulo.NomeDevedor,
                CPFDevedor = titulo.CPFDevedor,
                PorcentagemJuros = titulo.PorcentagemJuros,
                PorcentagemMulta = titulo.PorcentagemMulta,
                ParcelaDivida = titulo.ParcelaDivida,
                NumeroDaParcela = titulo.NumeroDaParcela,
                DataVencimento = titulo.DataVencimento,
                ValorDaParcela = titulo.ValorDaParcela,
            };
        }


        public static Titulo ToEntity(this TituloViewModel tituloViewModel)
        {
            if (tituloViewModel == null) return null;

            return new Titulo
            {
                Id = tituloViewModel.Id,
                NumeroTitulo = tituloViewModel.NumeroTitulo,
                NomeDevedor = tituloViewModel.NomeDevedor,
                CPFDevedor = tituloViewModel.CPFDevedor,
                PorcentagemJuros = tituloViewModel.PorcentagemJuros,
                PorcentagemMulta = tituloViewModel.PorcentagemMulta,
                ParcelaDivida = tituloViewModel.ParcelaDivida,
                NumeroDaParcela = tituloViewModel.NumeroDaParcela,
                DataVencimento = tituloViewModel.DataVencimento,
                ValorDaParcela = tituloViewModel.ValorDaParcela,
            };
        }
    }
}
