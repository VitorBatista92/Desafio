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
                new Titulo
                {
                    Id = Guid.Parse("4ff32602-b9cf-4ec6-965f-5335e03fd08a"),
                    DateCreated = new DateTime(2025, 1, 1),
                    IsDeleted = false,
                    DateUpdated = null,
                    NumeroTitulo = "000001",
                    NomeDevedor = "Devedor de teste",
                    CPFDevedor = "00000000000",
                    PorcentagemJuros = 5,
                    PorcentagemMulta = 10,
                    ParcelaDivida = 1,
                    DataVencimento = new DateTime(2026, 1, 1),
                    ValorDaParcela = 100000
                },
                new Titulo
                {
                    Id = Guid.Parse("94f4d913-108b-4cb7-8d1e-f532c5ef3402"),
                    DateCreated = new DateTime(2025, 1, 1),
                    IsDeleted = false,
                    DateUpdated = null,
                    NumeroTitulo = "000002",
                    NomeDevedor = "Devedor de teste 2",
                    CPFDevedor = "00000000000",
                    PorcentagemJuros = 5,
                    PorcentagemMulta = 7,
                    ParcelaDivida = 2,
                    DataVencimento = new DateTime(2026, 1, 1),
                    ValorDaParcela = 50000
                },
                new Titulo
                {
                    Id = Guid.Parse("7bf008c7-58d2-4d9c-b14a-2809a9df9a80"),
                    DateCreated = new DateTime(2025, 1, 1),
                    IsDeleted = false,
                    DateUpdated = null,
                    NumeroTitulo = "000003",
                    NomeDevedor = "Devedor de teste 3",
                    CPFDevedor = "00000000000",
                    PorcentagemJuros = 3,
                    PorcentagemMulta = 2,
                    ParcelaDivida = 20,
                    DataVencimento = new DateTime(2027, 1, 1),
                    ValorDaParcela = 40000
                }
            );

            return builder;
        }
    }
}
