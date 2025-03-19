

namespace CleanArchitecture.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity:class // dynamic repository 
    {
        ValueTask<TEntity> AddAsync(TEntity entity);
        ValueTask<TEntity> Read(string EntityId);

        ValueTask<IEnumerable<TEntity>> ReadAll();

        void  UpdtaeAsync(TEntity entity);
        ValueTask DeleteAsync(string entityId);

        int SaveChanges();


    }
}

// réutilisabilité 
