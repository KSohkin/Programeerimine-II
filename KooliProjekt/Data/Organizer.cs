using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Organizer
    {
        
        [Required]
        public String ID { get; set; }
        
        [Required]
        [StringLength(100)]
        public String Name { get; set; }
        
        [Required]
        [StringLength(255)]
        public String Description { get; set; }
    }
}
