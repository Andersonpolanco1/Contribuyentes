
namespace ContribuyentesApi.Core.Entities
{
    public class Contribuyente
    {
        public int Id { get; set; }
        public string RncCedula { get; set; }
        public string Nombre { get; set; }
        public int TipoContribuyenteId { get; set; }
        public TipoContribuyente TipoContribuyente { get; set; }
        public bool EstaActivo { get; set; }
        public IEnumerable<ComprobanteFiscal> ComprobantesFiscales { get; set; } = new List<ComprobanteFiscal>();
    }
}
