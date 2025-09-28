using Desafio.Application.Services;
using Desafio.Application.ViewModels;
using Desafio.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio.Back.Tests.Services
{
    public class TituloServiceTests
    {
        private TituloService tituloService;

        public TituloServiceTests() 
        {
            tituloService = new TituloService(new Mock<ITituloRepository>().Object);
        }

        [Fact]
        public void Post_SendingValidId()
        {
            var exception = Assert.Throws<Exception>(()=> tituloService.Post(new TituloViewModel { Id = Guid.NewGuid() }));
            Assert.Equal("Id tem que ser vazio", exception.Message);
        }
    }
}
