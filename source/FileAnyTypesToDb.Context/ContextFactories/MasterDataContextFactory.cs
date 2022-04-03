using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FileAnyTypesToDb.Context.ContextFactories
{
    public class MasterDataContextFactory : DbContext
    {
 
        public MasterDataContext Create(DbContextOptions<MasterDataContext> options)
        {
            var dbContext = new MasterDataContext(options);

            return dbContext;
        }
    }
}
