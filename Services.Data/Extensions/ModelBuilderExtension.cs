using Desafio.Domain.Entities;
using Desafio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Titulo>().HasData(
                new Titulo { 
                    Id = Guid.Parse("4ff32602-b9cf-4ec6-965f-5335e03fd08a"),
                    DateCreated  = new DateTime(2025, 1, 1),
                    IsDeleted = false,
                    DateUpdated = null,
                    NumeroTitulo = "000001",
                    NomeDevedor = "Devedor de teste",
                    CPFDevedor = "00000000000",
                    PorcentagemJuros = 5,
                    PorcentagemMulta = 10,
                    ParcelaDivida = 1,
                    DataVencimento = new DateTime(2026, 1,1),
                    ValorDaParcela = 100000
    }
            );

            return builder;
        }
    }
}
