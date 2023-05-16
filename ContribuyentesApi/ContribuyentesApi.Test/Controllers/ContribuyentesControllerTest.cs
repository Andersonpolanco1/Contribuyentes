using AutoMapper;
using ContribuyentesApi.Core.Interfaces.Services;
using ContribuyentesApi.Test.Services;
using ContribuyentesApi.Web.Controllers;
using ContribuyentesApi.Web.DTOs;
using ContribuyentesApi.Web.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace ContribuyentesApi.Test.Controllers
{
    public class ContribuyentesControllerTest
    {
        private readonly ContribuyentesController _controller;
        private readonly IContribuyenteService _contribuyenteService;
        private IMapper _mapper;


        public ContribuyentesControllerTest()
        {
            ObtenerAutoMapper();
            _contribuyenteService = new ContribuyenteServiceFake();
            _controller = new ContribuyentesController(_contribuyenteService, _mapper);
        }

        [Fact]
        public async Task ObtenerComprobantes_Sin_Rnc_Retorna_Ok()
        {
            string? rncCedula = null;

            // Act
            var okResult = await _controller.ObtenerTodosLosComprobantes(rncCedula);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public async Task ObtenerComprobantes_Con_Rnc_Retorna_Ok()
        {
            string? rncCedula = "98754321012";

            // Act
            var okResult = await _controller.ObtenerTodosLosComprobantes(rncCedula);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public async Task ObtenerComprobantes_Sin_Parametros_retorna_todos_los_Items()
        {
            string? rncCedula = null;

            // Act
            var okResult = await _controller.ObtenerTodosLosComprobantes(rncCedula) as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<ComprobanteFiscalDto>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public async Task Obtener_Contribuyente_Existente_Por_RncCedula_Retorna_Ok()
        {
            // Arrange
            string? rncCedula = "98754321012";

            // Act
            var okResult = await _controller.ObtenerTodosLosContribuyentes(rncCedula);
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public async Task Obtener_Contribuyente_Existente_Por_RncCedula_Retorna_Lista_De_Un_Contribuyente()
        {
            // Arrange
            string? rncCedula = "98754321012";
            // Act
            var okResult = await _controller.ObtenerTodosLosContribuyentes(rncCedula) as OkObjectResult;
            // Assert
            Assert.IsType<List<ContribuyenteDto>>(okResult.Value);

            var contribuyentes = okResult.Value as  List<ContribuyenteDto>;

            Assert.Equal("98754321012", contribuyentes.FirstOrDefault().RncCedula);
            Assert.Equal(1, contribuyentes.Count);
        }



        private void ObtenerAutoMapper()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new ContribuyenteProfile());
                    mc.AddProfile(new ComprobanteFiscalProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }


    }
}