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
    }
}
