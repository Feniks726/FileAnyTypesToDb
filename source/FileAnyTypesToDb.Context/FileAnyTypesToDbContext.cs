using System.Data.Entity;
using FileAnyTypesToDb.Domain.Models;

namespace FileAnyTypesToDb.Context
{
    public class FileAnyTypesToDbContext : DbContext
    {
        public FileAnyTypesToDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<FileData> FileDatas { get; set; }
    }
}
