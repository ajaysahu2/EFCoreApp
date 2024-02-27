using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Student")]
    public class Student
    {
        public Guid StudentId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public required string Name { get; set; }
        public int? Age { get; set; }
        public bool IsRegularStudent { get; set; }
    }
}
