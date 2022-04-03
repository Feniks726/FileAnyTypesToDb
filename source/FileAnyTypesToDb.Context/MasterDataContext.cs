using System.Data.Entity;
using FileAnyTypesToDb.Domain.Models;

namespace FileAnyTypesToDb.Context
{
    public class MasterDataContext : DbContext
    {
        public DbSet<FileExtentions> FileExtentions { get; set; }
        public DbSet<FileData> FileDatas { get; set; }
    }
}