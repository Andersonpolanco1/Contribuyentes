using ContribuyentesApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContribuyentesApi.Infrastructure.Data.Configurations
{
    public class ComprobanteFiscalConfiguration : IEntityTypeConfiguration<ComprobanteFiscal>
    {
        public void Configure(EntityTypeBuilder<ComprobanteFiscal> builder)
        {
            builder.ToTable("ComprobantesFiscales");
        }
    }
}
