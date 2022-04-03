using FileAnyTypesToDb.Domain.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using FileAnyTypesToDb.Context;

namespace FileAnyTypesToDb.Service.Services
{
    public class RefreshService
    {
        public List<FileData> Get()
        {
            List<FileData> result = null;
            var connectionString = ConfigurationManager.ConnectionStrings["MasterDataContext"].ConnectionString;

            using (var context = new FileAnyTypesToDbContext(connectionString))
            {
                result = context.FileDatas.ToList();
            }

            return result;
        }
    }
}
