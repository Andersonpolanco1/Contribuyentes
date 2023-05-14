using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Core.Interfaces.Repositories
{
    public interface IContribuyenteRepository : IBaseRepository<Contribuyente>
    {
        Task<Contribuyente?> ObtenerPorId(int id);
        Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes();
        Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorIdContribuyente(int idContribuyente);
        Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes();
        
    }
}
