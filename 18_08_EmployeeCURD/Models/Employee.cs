using System.ComponentModel.DataAnnotations;

namespace _18_08_EmployeeCURD.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        public string Designation { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
