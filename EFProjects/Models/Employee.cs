using System.ComponentModel.DataAnnotations;

namespace EFProjects.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [StringLength(50)]
        public string Position { get; set; }

        [Range(1000, 100000, ErrorMessage = "Salary must be between 1000 and 100000")]
        public decimal Salary { get; set; }
    }
}
