using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Organizer
    {
        
        [Required]
        public required String ID { get; set; }
        
        [Required]
        [StringLength(100)]
        public required String Name { get; set; }
        
        [Required]
        [StringLength(255)]
        public required String Description { get; set; }
    }
}
