using WikY.Entities.Common;

namespace WikY.Repository.Persistence.Repositories.Base;

public interface IReadRepository<TEntity, TId> where TEntity : Entity<TId>
{
    /// <summary>
    /// Get a <typeparamref name="TEntity"/> by his id 
    /// </summary>
    /// <param name="id"> <typeparamref name="Tid"/> of the <typeparamref name="TEntity"/> id to find</param>
    /// <returns>returns a <typeparamref name="Tid"/> of the <typeparamref name="TEntity"/> id</returns>
    Task<TEntity?> GetById(TId id);

    /// <summary>
    /// Method for getting all the <typeparamref name="TEntity"/> 
    /// </summary>
    /// <returns>returns an <typeparamref name="List"/> of all the <typeparamref name="TEntity"/></returns>
    Task<List<TEntity>> GetAll();
}
