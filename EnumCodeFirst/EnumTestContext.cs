using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EnumCodeFirst
{
    public class EnumTestContext : DbContext
    {
        public EnumTestContext() : base("Name=EnumTest") { }    // Use the connection from app.config

        static EnumTestContext()  
        {
            //Database.SetInitializer<EnumTestContext>(null);   // turn off database initialization and migrations
            Database.SetInitializer(new EnumDatabaseInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Department> Departments { get; set; }
    }
}