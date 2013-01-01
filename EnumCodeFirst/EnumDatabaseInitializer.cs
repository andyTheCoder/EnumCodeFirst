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
            Department mathsDept = context.Departments.Add(new Department() { Name = DepartmentNames.Maths, DepartmentHeadName = "andy" });
            Department economicsDept = context.Departments.Add(new Department() { Name = DepartmentNames.Economics, DepartmentHeadName = "fred"});
            context.SaveChanges();

            context.People.Add(new Student() { Name = "pupil A", DepartmentId = mathsDept.DepartmentId });
            context.People.Add(new Student() { Name = "pupil B", DepartmentId = mathsDept.DepartmentId });
            context.People.Add(new Student() { Name = "pupil C", DepartmentId = economicsDept.DepartmentId });
            context.SaveChanges();
        }
    }
}