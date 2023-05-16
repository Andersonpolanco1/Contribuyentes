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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ContribuyenteDto>))]
        public async Task<ActionResult<IEnumerable<ContribuyenteDto>>> ObtenerTodos()
        {
            var contribuyentes = await _ContribuyenteService.ObtenerTodos();
            var contribuyentesDto = _mapper.Map<IEnumerable<Contribuyente>, IEnumerable<ContribuyenteDto>>(contribuyentes);

            return Ok(contribuyentesDto);
        }

        [HttpGet("{rncCedula}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ContribuyenteDto))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ContribuyenteDto>>> ObtenerContribuyente([FromQuery] string? rncCedula)
        {
            var contribuyente = await _ContribuyenteService.ObtenerPorRncCedula(rncCedula);

            return contribuyente is null ? Ok() : Ok(_mapper.Map<Contribuyente, ContribuyenteDto>(contribuyente));
        }


        [HttpGet("comprobantes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ComprobanteFiscalDto>))]
        public async Task<ActionResult<IEnumerable<ComprobanteFiscalDto>>> ObtenerComprobantes()
        {
            var comprobantes = await _ContribuyenteService.ObtenerTodosLosComprobantes();
            var comprobantesDto = _mapper.Map<IEnumerable<ComprobanteFiscal>, IEnumerable<ComprobanteFiscalDto>>(comprobantes);

            return Ok(comprobantesDto);
        }

        [HttpGet("{rncCedula}/comprobantes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ComprobanteFiscalDto>))]
        public async Task<ActionResult<IEnumerable<ComprobanteFiscalDto>>> ObtenerComprobantes([FromRoute] string rncCedula)
        {
            var comprobantes = await _ContribuyenteService.ObtenerComprobantesPorRncCedulaContribuyente(rncCedula);
            var comprobantesDto = _mapper.Map<IEnumerable<ComprobanteFiscal>, IEnumerable<ComprobanteFiscalDto>>(comprobantes);

            return Ok(comprobantesDto);
        }
    }
}
