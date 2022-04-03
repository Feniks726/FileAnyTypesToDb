using System;
using System.Configuration;
using System.Linq;
using FileAnyTypesToDb.Context;

namespace FileAnyTypesToDb.Service.Services
{
    public class DeleteService
    {
        public void Execute(Guid id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MasterDataContext"].ConnectionString;

            using (var context = new FileAnyTypesToDbContext(connectionString))
            {
                var row = context.FileDatas.FirstOrDefault(t => t.Id == id);

                if (row==null) return;
               
                context.FileDatas.Remove(row);
                context.SaveChanges();
            }
        }
    }
}
