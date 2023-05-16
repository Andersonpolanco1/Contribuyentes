using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Core.Interfaces.Services
{
    public interface IContribuyenteService
    {
        Task<Contribuyente?> ObtenerPorRncCedula(string rncCedula);
        Task<IEnumerable<Contribuyente>> ObtenerTodos();
        Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorRncCedulaContribuyente(string rncCedula);
        Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes();

    }
}
