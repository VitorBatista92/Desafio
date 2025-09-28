using Desafio.Data.Context;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Data.Repositories
{
    public class TituloRepository: Repository<Titulo>, ITituloRepository
    {
        public TituloRepository(DesafioContext context) : base(context) { }

    }
}
