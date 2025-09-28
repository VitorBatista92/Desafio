using Desafio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Data.Mappings
{
    public class TituloMap: IEntityTypeConfiguration<Titulo>
    {
        public void Configure(EntityTypeBuilder<Titulo> builder) 
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.NomeDevedor).HasMaxLength(100).IsRequired();
            builder.Property(x => x.NumeroTitulo).HasMaxLength(20).IsRequired();
            builder.Property(x => x.CPFDevedor).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PorcentagemJuros).IsRequired();
            builder.Property(x => x.PorcentagemMulta).IsRequired();
            builder.Property(x => x.ParcelaDivida).IsRequired();
            builder.Property(x => x.NumeroDaParcela).IsRequired();
            builder.Property(x => x.DataVencimento).IsRequired();
            builder.Property(x => x.ValorDaParcela).IsRequired();
        }
    }
}
