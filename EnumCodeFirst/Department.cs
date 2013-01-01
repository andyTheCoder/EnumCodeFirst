using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnumCodeFirst
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public DepartmentNames Name { get; set; }
        [MaxLength(30), Required, Column("DeptHeadName")]   // DefaultValue("some bloke") --> does not work
        public string DepartmentHeadName { get; set; }
        public decimal Budget { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}