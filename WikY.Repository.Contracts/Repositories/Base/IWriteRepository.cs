﻿using WikY.Entities.Common;

namespace WikY.Repository.Persistence.Repositories.Base;

public interface IWriteRepository<TEntity, TId> where TEntity : Entity<TId>
{
    /// <summary>
    /// Create a <typeparamref name="TEntity"/>
    /// </summary>
    /// <param name="entity">The <typeparamref name="TEntity"/> to create</param>
    /// <returns>The <typeparamref name="TEntity"/> created</returns>
    Task<TEntity> Create(TEntity entity);

    /// <summary>
    /// Modify a <typeparamref name="TEntity"/>
    /// </summary>
    /// <param name="entity">The <typeparamref name="TEntity"/> to modify</param>
    /// <returns>The <typeparamref name="TEntity"/> created</returns>
    Task<TEntity> Update(TEntity entity);

    /// <summary>
    /// Delete a <typeparamref name="TEntity"/>
    /// </summary>
    /// <param name="entity">The <typeparamref name="TEntity"/> to delete</param>
    Task Delete(TEntity entity);
}
