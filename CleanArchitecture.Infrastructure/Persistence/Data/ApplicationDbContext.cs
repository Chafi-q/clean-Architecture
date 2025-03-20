

using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.Data
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) 
        {

            
        }
    }
}

// après en implemente note dbset  chaque dbset = une table dans la base de données 

