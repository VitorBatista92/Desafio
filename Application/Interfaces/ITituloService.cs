using Desafio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Application.Interfaces
{
    public interface ITituloService
    {
        List<TituloViewModel> GetAll();
        TituloViewModel GetById(string id);

        bool Post(TituloViewModel tituloViewModel);
        bool Put(TituloViewModel tituloViewModel);
        bool Delete(string id);
    }
}
