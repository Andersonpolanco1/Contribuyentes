using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Repositories;
using ContribuyentesApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ContribuyentesApi.Infrastructure.Repositories
{
    public class ContribuyenteRepository : BaseRepository<Contribuyente>, IContribuyenteRepository
    {
        private readonly ILogger<ContribuyenteRepository> _logger;

        public ContribuyenteRepository(ApplicationDbContext context, ILogger<ContribuyenteRepository> logger) : base(context)
        {
            _logger =logger;
        }

        public async Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes(string? rncCedula)
        {
            if(rncCedula is null)
            {
                _logger.LogInformation($"Obteniendo contribuyentes...");
                return await _context.Contribuyentes.Include(c => c.TipoContribuyente).ToListAsync();
            }

            _logger.LogInformation($"Obteniendo contribuyentes RNC / Cedula: {rncCedula}");
            return await _context.Contribuyentes.Include(c => c.TipoContribuyente).Where(c => c.RncCedula == rncCedula).ToListAsync();
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes(string? rncCedula)
        {
            if (rncCedula is null)
            {
                _logger.LogInformation($"Obteniendo comprobantes fiscales...");
                return await _context.ComprobantesFiscales.Include(c => c.Contribuyente).ToListAsync();
            }

            _logger.LogInformation($"Obteniendo comprobantes con RNC / Cedula: {rncCedula}");
            return await _context.ComprobantesFiscales.Include(c => c.Contribuyente).Where(c => c.Contribuyente.RncCedula == rncCedula).ToListAsync();
        }
    }
}
