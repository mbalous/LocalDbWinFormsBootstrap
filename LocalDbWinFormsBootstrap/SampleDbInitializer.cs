using LocalDbWinFormsBootstrap.Entities;
using System.Data.Entity;

namespace LocalDbWinFormsBootstrap
{
    public class SampleDbInitializer : SQLite.CodeFirst.SqliteCreateDatabaseIfNotExists<SampleDbContext>
    {
        public SampleDbInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {
        }

        protected override void Seed(SampleDbContext context)
        {
            // Do you database initializing here
            context.Set<Person>().Add(new Person { Name = "John Doe" });
        }
    }
}
