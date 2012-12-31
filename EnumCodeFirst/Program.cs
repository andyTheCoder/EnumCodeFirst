using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumCodeFirst
{
    public class Program
    {

        static void Main(string[] args)
        {
            using (var db = new EnumTestContext())
            {
                //db.Departments.Add(new Department() { Name = DepartmentNames.Maths, DepartmentHeadName = "fred" });
                //db.Departments.Add(new Department() { Name = DepartmentNames.Economics });
                //db.SaveChanges();

                Department dept = (from d in db.Departments
                            where d.Name == DepartmentNames.Maths
                            select d).FirstOrDefault();



            }
        }
    }
}
