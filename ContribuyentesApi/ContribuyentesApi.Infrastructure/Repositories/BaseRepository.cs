using ContribuyentesApi.Core.Interfaces.Repositories;
using ContribuyentesApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace ContribuyentesApi.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        internal ApplicationDbContext _context;
        internal DbSet<TEntity> _dbSet;
        internal ILogger _logger;


        public BaseRepository(ApplicationDbContext context, ILogger logger)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
            _logger = logger;
        }

        public async Task<TEntity?> ObtenerPorId(int id)
        {
            TEntity? entidad = null;
            try 
            {
                _logger.LogInformation($"Buscando entidad {typeof(TEntity)} con el id {id}.");
                entidad =  await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Ha ocurrido un error al momento de buscar la entidad {typeof(TEntity)} con el id {id}.");
            }
            return entidad;

        }
    }
}
