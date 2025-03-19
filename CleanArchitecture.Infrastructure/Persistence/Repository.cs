using CleanArchitecture.Core.Interfaces


namespace CleanArchitecture.Infrastructure.Persistence
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public ValueTask<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> Read(string EntityId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<TEntity>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> UpdtaeAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
