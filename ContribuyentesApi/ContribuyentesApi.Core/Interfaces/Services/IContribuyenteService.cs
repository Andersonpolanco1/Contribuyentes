using ContribuyentesApi.Core.Entities;

namespace ContribuyentesApi.Core.Interfaces.Services
{
    public interface IContribuyenteService
    {
        /// <summary>
        /// Buscar todos los contribuyentes, se puede filtrar por RNC o Cédula opcional
        /// </summary>
        /// <param name="rncCedula"></param>
        /// <returns></returns>
        Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes(string? rncCedula);


        /// <summary>
        /// Buscar todos los comprobantes fiscales, se puede filtrar por RNC o Cédula opcional
        /// </summary>
        /// <param name="rncCedula"></param>
        /// <returns></returns>
        Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes(string? rncCedula);
    }
}
