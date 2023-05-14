using System.ComponentModel.DataAnnotations.Schema;

namespace ContribuyentesApi.Core.Entities
{
    public class ComprobanteFiscal
    {
        public int Id { get; set; }
        public int ContribuyenteId { get; set; }
        public string Ncf { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Monto { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Itbis { get; set; }
        public Contribuyente Contribuyente { get; set; }

    }
}
