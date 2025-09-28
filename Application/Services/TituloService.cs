using Desafio.Application.Extensions;
using Desafio.Application.Interfaces;
using Desafio.Application.ViewModels;
using Desafio.Domain.Entities;
using Desafio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Application.Services
{
    public class TituloService: ITituloService
    {
        readonly ITituloRepository tituloRepository;
        public TituloService(ITituloRepository tituloRepository)
        {
            this.tituloRepository = tituloRepository;
        }

        public List<TituloViewModel> GetAll() 
        {
            List<TituloViewModel> _tituloViewModels = new List<TituloViewModel>();

            IEnumerable<Titulo> _titulos = tituloRepository.Query(x => !x.IsDeleted);

            foreach(var titulo in _titulos)
            {
                _tituloViewModels.Add(TituloExtensions.ToViewModel(titulo));
            }

            return _tituloViewModels;
        }

        public TituloViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid tituloId))
                throw new ArgumentNullException("id");

            Titulo _titulo = tituloRepository.Find(x => x.Id == tituloId && !x.IsDeleted);

            if (_titulo == null)
                throw new Exception("Titulo nao encontrado");

            return TituloExtensions.ToViewModel(_titulo);
        }

        public bool Post(TituloViewModel tituloViewModel)
        {
            if (tituloViewModel.Id != null)
                throw new Exception("Id tem que ser vazio");

            Titulo _titulo = TituloExtensions.ToEntity(tituloViewModel);

            tituloRepository.Create(_titulo);

            return true;
        }

        public bool Put(TituloViewModel tituloViewModel)
        {

            Titulo _titulo = tituloRepository.Find(x => x.Id == tituloViewModel.Id && !x.IsDeleted);

            if (_titulo == null)
                throw new Exception("Titulo not found");

            _titulo = TituloExtensions.ToEntity(tituloViewModel);

            tituloRepository.Update(_titulo);

            return true;
        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid tituloId))
                throw new ArgumentNullException("id");

            Titulo _titulo = tituloRepository.Find(x => x.Id == tituloId && !x.IsDeleted);

            if (_titulo == null)
                throw new Exception("Titulo not found");

            tituloRepository.Delete(_titulo);

            return true;
        }
    }
}
