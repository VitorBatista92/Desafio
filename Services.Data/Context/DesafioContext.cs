using Desafio.Data.Extensions;
using Desafio.Data.Mappings;
using Desafio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Data.Context
{
    public class DesafioContext:DbContext
    {
        public DesafioContext(DbContextOptions<DesafioContext> option)
            : base(option) { }
        
        #region "DBSets"

        public DbSet<Titulo> titulos { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TituloMap());


            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
