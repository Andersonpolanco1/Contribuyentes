using System.Linq.Expressions;


namespace ContribuyentesApi.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> ObtenerPorId(int id);
    }
}
