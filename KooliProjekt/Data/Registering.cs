using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Registering
    {
        
        [Required]
        public required string ID { get; set; }

        
        [Required]
        public required string Client_ID { get; set; }

        
        [Required]
        public required string Payment_ID { get; set; }
        public DateTime Date { get; set; }
        
        [Required]
        public required string Event_ID { get; set; }

    }
}
