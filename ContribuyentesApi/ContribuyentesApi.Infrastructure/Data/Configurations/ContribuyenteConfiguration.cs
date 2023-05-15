using ContribuyentesApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace ContribuyentesApi.Infrastructure.Data.Configurations
{
    public class ContribuyenteConfiguration : IEntityTypeConfiguration<Contribuyente>
    {
        public void Configure(EntityTypeBuilder<Contribuyente> builder)
        {
            builder
            .HasIndex(b => b.RncCedula)
            .IsUnique();

            builder.ToTable("Contribuyentes");
        }
    }
}
