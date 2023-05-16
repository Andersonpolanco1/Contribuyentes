using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Services;
using ContribuyentesApi.Test.Data;

namespace ContribuyentesApi.Test.Services
{
    public class ContribuyenteServiceFake : IContribuyenteService
    {
        private ContribuyentesRepositoryFake _contribuyenteRepository;
        public ContribuyenteServiceFake()
        {
            _contribuyenteRepository = new ContribuyentesRepositoryFake();
        }

        public async Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes(string? rncCedula)
        {
            return await _contribuyenteRepository.ObtenerTodosLosContribuyentes(rncCedula);
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes(string? rncCedula)
        {
            return await _contribuyenteRepository.ObtenerTodosLosComprobantes(rncCedula);
        }
    }
}
