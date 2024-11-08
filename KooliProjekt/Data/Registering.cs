using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Registering
    {
        
        [Required]
        public required String ID { get; set; }

        
        [Required]
        public required String Client_ID { get; set; }

        
        [Required]
        public required String Payment_ID { get; set; }
        public DateTime Date { get; set; }
        
        [Required]
        public required String Event_ID { get; set; }

    }
}
