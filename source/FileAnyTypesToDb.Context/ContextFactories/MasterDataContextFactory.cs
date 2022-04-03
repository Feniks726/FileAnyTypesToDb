using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace OrdersProject.Context.ContextFactories
{
    public class MasterDataContextFactory : IDbContextFactory<MasterDataContext>
    {
        public MasterDataContext Create()
        {
            var dbContext = new MasterDataContext();

            dbContext.Database.CommandTimeout=int.Parse(ConfigurationManager.AppSettings["SQLCommandTimeOut"]);

            return dbContext;
        }
    }
}
