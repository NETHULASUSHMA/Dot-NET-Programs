using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MvcCodeFirstApproach_Sushma.Models
{
    [Table("tblEmployee")]
    public class EmployeeModel
    {
        [Key]
        public int id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }

        
    }
}
