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

        public async Task<IEnumerable<Contribuyente>> ObtenerTodos()
        {
            return await _contribuyenteRepository.ObtenerTodosLosContribuyentes();
        }

        public async Task<Contribuyente?> ObtenerPorRncCedula(string rncCedula)
        {
            return await _contribuyenteRepository.ObtenerPorId(rncCedula);
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorRncCedulaContribuyente(string rncCedula)
        {
            return await _contribuyenteRepository.ObtenerComprobantesPorRncCedulaContribuyente(rncCedula);
        }

        public Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes()
        {
            return _contribuyenteRepository.ObtenerTodosLosComprobantes();
        }
    }
}
