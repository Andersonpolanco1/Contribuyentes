using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuyentesApi.Test.Data
{
    public class ContribuyentesRepositoryFake : IContribuyenteRepository
    {
        public List<Contribuyente> Contribuyentes { get; set; }
        public List<ComprobanteFiscal> Comprobantes { get; set; }

        public ContribuyentesRepositoryFake()
        {
            Contribuyentes = new List<Contribuyente>
            {
               new Contribuyente
               {
                   Id = 1,
                   Nombre = "JUAN PEREZ",
                   TipoContribuyente = new TipoContribuyente
                   {
                       Id =1,
                       Descripcion ="PERSONA FISICA"
                   },
                   TipoContribuyenteId =1,
                   EstaActivo = true,
                   RncCedula ="98754321012"
               },
               new Contribuyente
               {
                   Id = 2,
                   Nombre = "FARMACIA TU SALUD",
                   TipoContribuyente = new TipoContribuyente
                   {
                       Id =2,
                       Descripcion ="PERSONA JURIDICA"
                   },
                   TipoContribuyenteId =2,
                   EstaActivo = false,
                   RncCedula ="123456789"
               }
            };

            Comprobantes = new List<ComprobanteFiscal>
            {
                new ComprobanteFiscal
                {
                    Id =1,
                    ContribuyenteId=1,
                    Contribuyente = new Contribuyente
                    {
                        RncCedula = "98754321012"
                    },
                    Itbis = 36.00m,
                    Monto= 200.00m,
                    Ncf = "E310000000001"
                },
                new ComprobanteFiscal
                {
                    Id =2,
                    ContribuyenteId=1,
                    Contribuyente = new Contribuyente
                    {
                        RncCedula = "98754321012"
                    },
                    Itbis = 180.00m,
                    Monto= 1000.00m,
                    Ncf = "E310000000001"
                }
            };
        }

        public async Task<IEnumerable<Contribuyente>> ObtenerTodosLosContribuyentes(string? rncCedula)
        {
            if (rncCedula is null)
            {
                return Contribuyentes;
            }

            return Contribuyentes.Where(c => c.RncCedula == rncCedula);
        }

        public async Task<IEnumerable<ComprobanteFiscal>> ObtenerTodosLosComprobantes(string? rncCedula)
        {
            if (rncCedula is null)
            {
                return Comprobantes;
            }

            return  Comprobantes.Where(c => c.Contribuyente.RncCedula == rncCedula);
        }
    }
}
