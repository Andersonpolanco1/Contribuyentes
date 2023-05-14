using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Core.Interfaces.Repositories
{
    public interface IContribuyenteRepository : IBaseRepository<Contribuyente>
    {
        Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorIdContribuyente(int idContribuyente);
    }
}
