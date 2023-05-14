using ContribuyentesApi.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContribuyentesApi.Web.DTOs
{
    public class ComprobanteFiscalDto
    {
        public string RncCedula { get; set; }
        public string NCF { get; set; }
        public string Monto { get; set; }
        public string Itbis { get; set; }
    }
}