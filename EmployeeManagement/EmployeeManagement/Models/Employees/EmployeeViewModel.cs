using EmployeeManagement.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.Employees
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public string Department { get; set; }
    }
}
