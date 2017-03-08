using LocalDbWinFormsBootstrap.Entities;    
using System.Data.Entity;

namespace LocalDbWinFormsBootstrap
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Configure();
        }

        private void Configure()
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Base call can be removed, because the default implementation does nothing.
            // Configure entities
            modelBuilder.Entity<Person>();
            Database.SetInitializer(new SampleDbInitializer(modelBuilder));
        }
    }
}
