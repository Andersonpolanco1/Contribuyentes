using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;


namespace ContribuyentesApi.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        public DbSet<TipoContribuyente> TiposContribuyentes { get; set; }
        public DbSet<Contribuyente> Contribuyentes { get; set; }
        public DbSet<ComprobanteFiscal> ComprobantesFiscales { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContribuyenteConfiguration());
            builder.ApplyConfiguration(new ComprobanteFiscalConfiguration());
            builder.ApplyConfiguration(new TipoComprobanteConfiguration());

        }

    }
}
