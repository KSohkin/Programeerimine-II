using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Organizer
    {
        
        [Required]
        public required string ID { get; set; }
        
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }
        
        [Required]
        [StringLength(255)]
        public required string Description { get; set; }
    }
}
