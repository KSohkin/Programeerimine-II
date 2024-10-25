using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Event
    {
        
        [Required]
        [StringLength(100)]
        public String ID { get; set; }
        
        [Required]
        public String Name { get; set; }
        
        [Required]
        public DateOnly Date { get; set; }
        
        [Required]
        public DateTime Time { get; set; }
        
        [Required]
        [StringLength(255)]
        public String Desscription { get; set; }
        
        [Required]
        public String Spots { get; set; }

        
        [Required]
        [StringLength(255)]
        public String Eventplan { get; set; }

        
        [Required]
        public String Price { get; set; }

        
        [Required]
        [StringLength(600)]
        public String Summary { get; set; }

        
        [Required]
        [StringLength(255)]
        public String Oraganizer { get; set; }

    }
}
