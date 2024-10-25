using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Payment
    {
        
        [Required]
        public String ID { get; set; }
        [Required]
        public String Amount { get; set; }

        
        [Required]
        public String PaymentNr { get; set; }
        
        [Required]
        public String Deadline { get; set; }

        [Required]
        [StringLength(255)]
        public String Description { get; set; }

    }
}
