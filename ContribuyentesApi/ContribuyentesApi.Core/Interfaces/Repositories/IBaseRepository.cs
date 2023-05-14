using System.Linq.Expressions;


namespace ContribuyentesApi.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> ObtenerPorId(int id);
        Task<IEnumerable<TEntity>> ObtenerTodos(Expression<Func<TEntity, bool>>? filtros = null,
                                                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? ordenarPor = null,
                                                string incluirPropiedades = "");
    }
}
