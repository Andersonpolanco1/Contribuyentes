using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Repositories;
using ContribuyentesApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ContribuyentesApi.Infrastructure.Repositories
{
    public class ContribuyenteRepository : BaseRepository<Contribuyente>, IContribuyenteRepository
    {
        public ContribuyenteRepository(ApplicationDbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorIdContribuyente(int idContribuyente)
        {
            var contribuyente = await Context.Contribuyentes.Include(c => c.ComprobantesFiscales).FirstOrDefaultAsync(c => idContribuyente == c.Id);

            return (contribuyente is null || contribuyente.ComprobantesFiscales is null) ? new List<ComprobanteFiscal>() : contribuyente.ComprobantesFiscales;
        }

        public async Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes()
        {
            return await Context.Contribuyentes.Include(c => c.TipoContribuyente).ToListAsync();
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes()
        {
            return await Context.ComprobantesFiscales.Include(c => c.Contribuyente).ToListAsync();
        }
    }
}
