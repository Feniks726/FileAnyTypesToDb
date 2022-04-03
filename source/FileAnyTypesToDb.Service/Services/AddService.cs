using System;
using System.Configuration;
using System.Linq;
using FileAnyTypesToDb.Context;
using FileAnyTypesToDb.Domain.Models;

namespace FileAnyTypesToDb.Service.Services
{
    public class AddService
    {
        public void Execute(string fileName, byte[] data)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MasterDataContext"].ConnectionString;

            using (var context = new FileAnyTypesToDbContext(connectionString))
            {
                var row = new FileData
                {
                    Id = Guid.NewGuid(),
                    FileName = fileName,
                    Content = data
                };

                context.FileDatas.Add(row);
                context.SaveChanges();
            }
        }
    }
}
