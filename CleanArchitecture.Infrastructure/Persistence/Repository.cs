using CleanArchitecture.Core.Interfaces;


using CleanArchitecture.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private ApplicationDbContext _context = null;
        private DbSet<TEntity> _entity;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
            
        }
        public async ValueTask<TEntity> AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            return entity;
        }

        public async ValueTask<TEntity> Read(string EntityId)
        {
            return await _entity.FindAsync(EntityId);
        }

        public async  ValueTask<IEnumerable<TEntity>> ReadAll()
        {
            return await _entity.ToListAsync();

        }


        public  void  UpdtaeAsync(TEntity entity)
        {
            _entity.Attach(entity);
        }

        public async ValueTask DeleteAsync(string entityId)
        {
            var oData = await _entity.FindAsync(entityId);
            _entity.Remove(oData);

        }

         public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}


// valueTask = task more performant than task