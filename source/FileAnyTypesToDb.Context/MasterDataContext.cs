using System.Data.Entity;
using FileAnyTypesToDb.Domain.Models;

namespace FileAnyTypesToDb.Context
{
    public class MasterDataContext : DbContext
    {
        //public MasterDataContext(DbContextOptions<MasterDataContext> options) : base(options)
        //{
        //}

        public DbSet<FileExtentions> FileExtentions { get; set; }
        public DbSet<FileData> FileDatas { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FileExtentions>().Property(t => t.Name).HasColumnType("nvarchar(6)");
        //    modelBuilder.Entity<FileExtentions>()
        //        .HasKey(t => t.Id);
        //    modelBuilder.Entity<FileExtentions>().Property(t => t.Id).ValueGeneratedOnAdd();

        //    modelBuilder.Entity<FileData>().Property(t => t.FileName).HasColumnType("nvarchar(255)");
        //    modelBuilder.Entity<FileData>()
        //        .HasKey(t => t.Id);
        //    modelBuilder.Entity<FileData>()
        //        .HasIndex(t => t.FileExtentionsId);
        //    modelBuilder.Entity<FileData>().Property(t => t.Id).ValueGeneratedOnAdd();

        //    modelBuilder.Entity<FileData>().HasOne(t => t.FileExtention).WithMany().OnDelete(DeleteBehavior.SetNull);
        //}
    }
}