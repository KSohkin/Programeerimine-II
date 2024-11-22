using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Event
    {
        
        [Required]
        [StringLength(100)]
        public required string ID { get; set; }
        
        [Required]
        public required string Name { get; set; }
        
        [Required]
        public required DateTime Time { get; set; }
        
        [Required]
        [StringLength(255)]
        public required string Description { get; set; }
        
        [Required]
        public required string Spots { get; set; }

        
        [Required]
        [StringLength(255)]
        public required string Eventplan { get; set; }

        
        [Required]
        public required string Price { get; set; }

        
        [Required]
        [StringLength(600)]
        public required string Summary { get; set; }

        
        [Required]
        [StringLength(255)]
        public required string Organizer { get; set; }

    }
}
