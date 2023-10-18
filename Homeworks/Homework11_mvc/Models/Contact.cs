using System.ComponentModel.DataAnnotations;

namespace Homework11_mvc.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? ContactName { get; set; }
		
        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? AlterPhone { get; set; }
        
        [Required]
        public string? Email { get; set; } 
        
        [Required]
        public string? TextAboutNumber { get; set; }
    }
}

