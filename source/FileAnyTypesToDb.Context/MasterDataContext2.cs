namespace FileAnyTypesToDb.Context
{
    public class MasterDataContext2 : DbContext
    {
        public MasterDataContext2() : base("name=MasterDataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
