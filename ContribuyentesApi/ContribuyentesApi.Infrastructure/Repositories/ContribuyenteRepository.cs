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

        public async Task<Contribuyente?> ObtenerPorId(string rncCedula)
        {
            _logger.LogInformation($"Buscando contribuyente {rncCedula}.");
            return await _context.Contribuyentes.Include(c => c.TipoContribuyente).FirstOrDefaultAsync(c => c.RncCedula == rncCedula);
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorRncCedulaContribuyente(string rncCedula)
        {
            _logger.LogInformation($"Obteniendo comprobantes del contribuyente  {rncCedula} ...");

            var contribuyente = await _context.Contribuyentes.Include(c => c.ComprobantesFiscales).FirstOrDefaultAsync(c => rncCedula == c.RncCedula);

            if(contribuyente is null)
                _logger.LogWarning($"Contribuyente no encontrado.");

            return (contribuyente is null || contribuyente.ComprobantesFiscales is null) ? new List<ComprobanteFiscal>() : contribuyente.ComprobantesFiscales;
        }

        public async Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes()
        {
            _logger.LogWarning($"Obteniendo todos los contribuyentes...");
            return await _context.Contribuyentes.Include(c => c.TipoContribuyente).ToListAsync();
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes()
        {
            _logger.LogWarning($"Obteniendo todos los comprobantes fiscales...");
            return await _context.ComprobantesFiscales.Include(c => c.Contribuyente).ToListAsync();
        }
    }
}
