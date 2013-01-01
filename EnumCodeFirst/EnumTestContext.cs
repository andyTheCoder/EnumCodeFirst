using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EnumCodeFirst
{
    public class EnumTestContext : DbContext
    {
        public EnumTestContext() : base("Name=EnumTest")    // Use the connection from app.config
        {
            //this.Configuration.LazyLoadingEnabled = false;  // turn off all lazy loading.  The other way is to remove the virtual keyword from the poco
        }

        static EnumTestContext()  
        {
            //Database.SetInitializer<EnumTestContext>(null);   // turn off database initialization and migrations
            Database.SetInitializer(new EnumDatabaseInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // Use singular table names
            //modelBuilder.Entity<Department>().Property(d => d.DepartmentHeadName).HasDatabaseGeneratedOption("xxx");

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> People { get; set; }
    }
}