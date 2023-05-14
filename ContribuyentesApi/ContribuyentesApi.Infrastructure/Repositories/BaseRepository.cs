using ContribuyentesApi.Core.Interfaces.Repositories;
using ContribuyentesApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace ContribuyentesApi.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        internal ApplicationDbContext Context;
        internal DbSet<TEntity> dbSet;


        public BaseRepository(ApplicationDbContext context)
        {
            Context = context;
            dbSet = context.Set<TEntity>();
        }

        public async ValueTask<TEntity> ObtenerPorId(int id)
        {
            var entity = await dbSet.FindAsync(id);

            return entity is null ? throw new Exception("No se encontro...") : entity;
        }
    }
}
