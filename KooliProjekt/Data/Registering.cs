using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Registering
    {
        
        [Required]
        public String ID { get; set; }

        
        [Required]
        public String Client_ID { get; set; }

        
        [Required]
        public String Payment_ID { get; set; }
        public DateTime Date { get; set; }
        
        [Required]
        public String Event_ID { get; set; }

    }
}
