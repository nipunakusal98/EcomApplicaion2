using System.ComponentModel.DataAnnotations;

namespace EcomApplicaion.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPassword { get; set; } 
        public string EmpType { get; set; }
    }
}
