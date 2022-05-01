using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ajax4.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }
    
}
