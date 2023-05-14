﻿using ContribuyentesApi.Core.Entities;
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

        public async Task<Contribuyente> ObtenerPorId(int id)
        {
            return await _contribuyenteRepository.ObtenerPorId(id);//manejar excepcion
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerComprobantesPorIdContribuyente(int idContribuyente)
        {
            return await _contribuyenteRepository.ObtenerComprobantesPorIdContribuyente(idContribuyente);
        }

        public Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes()
        {
            return _contribuyenteRepository.ObtenerTodosLosComprobantes();
        }
    }
}
