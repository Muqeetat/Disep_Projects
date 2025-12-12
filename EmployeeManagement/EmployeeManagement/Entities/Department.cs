using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation
        public List<Employee> Employees { get; set; } = [];
    }

}
