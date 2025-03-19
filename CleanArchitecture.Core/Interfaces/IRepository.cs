

namespace CleanArchitecture.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class // dynamic repository 
    {
        ValueTask<TEntity> AddAsync(TEntity entity);
        ValueTask<TEntity> Read(string EntityId);

        ValueTask<IEnumerable<TEntity>> ReadAll();

        ValueTask<TEntity> UpdtaeAsync(TEntity entity);
        ValueTask DeleteAsync(TEntity entity);


    }
}

// réutilisabilité 
