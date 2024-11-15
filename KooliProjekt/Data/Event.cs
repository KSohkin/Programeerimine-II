using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Event
    {
        
        [Required]
        [StringLength(100)]
        public required String ID { get; set; }
        
        [Required]
        public required String Name { get; set; }
        
        [Required]
        public required DateTime Time { get; set; }
        
        [Required]
        [StringLength(255)]
        public required String Description { get; set; }
        
        [Required]
        public required String Spots { get; set; }

        
        [Required]
        [StringLength(255)]
        public required String Eventplan { get; set; }

        
        [Required]
        public required String Price { get; set; }

        
        [Required]
        [StringLength(600)]
        public required String Summary { get; set; }

        
        [Required]
        [StringLength(255)]
        public required String Organizer { get; set; }

    }
}
