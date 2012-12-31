using System.Data.Entity;

namespace EnumCodeFirst
{
    public class EnumDatabaseInitializer :
        //CreateDatabaseIfNotExists<EnumTestContext>
        //DropCreateDatabaseIfModelChanges<EnumTestContext>
        DropCreateDatabaseAlways<EnumTestContext>

    {

        protected override void Seed(EnumTestContext context)
        {
            context.Departments.Add(new Department() { Name = DepartmentNames.Maths, DepartmentHeadName = "fred4" });
            context.Departments.Add(new Department() { Name = DepartmentNames.Economics });
            context.SaveChanges();
        }
    }
}