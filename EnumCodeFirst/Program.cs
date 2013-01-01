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
                var depts = (from d in db.Departments
                             select d).ToList();

                foreach (var d in depts)
                {
                    Console.WriteLine("Department: {0}", d.Name);
                    foreach (var s in d.Students)
                    {
                        Console.WriteLine("Student: {0}", s.Name);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
