using AutoMapper;
using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Services;
using ContribuyentesApi.Web.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ContribuyentesApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuyentesController : ControllerBase
    {
        private readonly IContribuyenteService _ContribuyenteService;
        private readonly IMapper _mapper;

        public ContribuyentesController(IContribuyenteService contribuyenteService, IMapper mapper)
        {
            _ContribuyenteService = contribuyenteService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{rncCedula}")]
        public async Task<ActionResult<IEnumerable<ContribuyenteDto>>> ObtenerContribuyente([FromRoute] string rncCedula)
        {
            var contribuyente = await _ContribuyenteService.ObtenerPorId(rncCedula);

            return contribuyente is null ? Ok() : Ok(_mapper.Map<Contribuyente, ContribuyenteDto>(contribuyente));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContribuyenteDto>>> ObtenerTodos()
        {
            var contribuyentes = await _ContribuyenteService.ObtenerTodos();
            var contribuyentesDto = _mapper.Map<IEnumerable<Contribuyente>, IEnumerable<ContribuyenteDto>>(contribuyentes);

            return Ok(contribuyentesDto);
        }

        [HttpGet]
        [Route("comprobantes")]
        public async Task<ActionResult<IEnumerable<ComprobanteFiscalDto>>> ObtenerComprobantes()
        {
            var comprobantes = await _ContribuyenteService.ObtenerTodosLosComprobantes();
            var comprobantesDto = _mapper.Map<IEnumerable<ComprobanteFiscal>, IEnumerable<ComprobanteFiscalDto>>(comprobantes);

            return Ok(comprobantesDto);
        }

        [HttpGet]
        [Route("{rncCedula}/comprobantes")]
        public async Task<ActionResult<IEnumerable<ComprobanteFiscalDto>>> ObtenerComprobantes([FromRoute] string rncCedula)
        {
            var comprobantes = await _ContribuyenteService.ObtenerComprobantesPorRncCedulaContribuyente(rncCedula);
            var comprobantesDto = _mapper.Map<IEnumerable<ComprobanteFiscal>, IEnumerable<ComprobanteFiscalDto>>(comprobantes);

            return Ok(comprobantesDto);
        }
    }
}
