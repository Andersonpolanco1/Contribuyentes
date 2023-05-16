using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Repositories;
using ContribuyentesApi.Core.Interfaces.Services;

namespace ContribuyentesApi.Services
{
    public class ContribuyentesService : IContribuyenteService
    {
        private readonly IContribuyenteRepository _contribuyenteRepository;

        public ContribuyentesService(IContribuyenteRepository contribuyenteRepository)
        {
            _contribuyenteRepository = contribuyenteRepository;
        }

        public async Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes(string? rncCedula)
        {
            return await _contribuyenteRepository.ObtenerTodosLosContribuyentes(rncCedula);
        }

        public async  Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes(string? rncCedula)
        {
            return await _contribuyenteRepository.ObtenerTodosLosComprobantes(rncCedula);
        }
    }
}
