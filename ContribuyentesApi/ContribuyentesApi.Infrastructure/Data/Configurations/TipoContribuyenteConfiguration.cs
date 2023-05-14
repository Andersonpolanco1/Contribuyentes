using ContribuyentesApi.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ContribuyentesApi.Infrastructure.Data.Configurations
{
    public class TipoComprobanteConfiguration : IEntityTypeConfiguration<TipoContribuyente>
    {
        public void Configure(EntityTypeBuilder<TipoContribuyente> builder)
        {
            builder.ToTable("TiposContribuyentes");
        }
    }
}
