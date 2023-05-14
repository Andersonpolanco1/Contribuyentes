using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Core.Interfaces.Services
{
    public interface IContribuyenteService
    {
        Task<Contribuyente?> ObtenerPorId(int id);
        Task<IEnumerable<Contribuyente>> ObtenerTodos();
        Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorIdContribuyente(int idContribuyente);
        Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes();

    }
}
