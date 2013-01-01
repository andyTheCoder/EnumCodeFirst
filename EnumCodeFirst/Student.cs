using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnumCodeFirst
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
}