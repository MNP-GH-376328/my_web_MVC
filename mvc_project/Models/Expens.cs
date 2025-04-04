using System.ComponentModel.DataAnnotations;

namespace mvc_project.Models
{
    public class Expens
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        [Required]
        public String? Description  { get; set; }
    }
}
