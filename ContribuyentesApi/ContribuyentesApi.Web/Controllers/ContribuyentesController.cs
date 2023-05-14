using AutoMapper;
using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Services;
using ContribuyentesApi.Web.DTOs;
using Microsoft.AspNetCore.Http;
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
        public async Task<ActionResult<IEnumerable<ContribuyenteDto>>> ObtenerTodos()
        {
            var contribuyentes = await _ContribuyenteService.ObtenerTodos();
            var contribuyentesDto = _mapper.Map<IEnumerable<Contribuyente>, IEnumerable<ContribuyenteDto>>(contribuyentes);

            return Ok(contribuyentesDto);
        }

        [HttpGet]
        [Route("{contribuyenteId}/comprobantes")]
        public async Task<ActionResult<IEnumerable<ComprobanteFiscalDto>>> ObtenerComprobantes([FromRoute] int contribuyenteId)
        {
            var comprobantes = await _ContribuyenteService.ObtenerComprobantesPorIdContribuyente(contribuyenteId);
            var comprobantesDto = _mapper.Map<IEnumerable<ComprobanteFiscal>, IEnumerable<ComprobanteFiscalDto>>(comprobantes);

            return Ok(comprobantesDto);
        }
    }
}
