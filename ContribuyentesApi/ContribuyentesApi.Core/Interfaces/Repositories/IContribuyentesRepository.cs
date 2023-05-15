using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Core.Interfaces.Repositories
{
    public interface IContribuyenteRepository : IBaseRepository<Contribuyente>
    {
        Task<Contribuyente?> ObtenerPorId(string rncCedula);
        Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes();
        Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorRncCedulaContribuyente(string rncCedula);
        Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes();
        
    }
}
