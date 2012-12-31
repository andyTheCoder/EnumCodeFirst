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
        [MaxLength(30), Required, Column("DeptHeadName"), DefaultValue("some bloke")]
        public string DepartmentHeadName { get; set; }
        public decimal Budget { get; set; }
    }
}