using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Payment
    {
        
        [Required]
        public required String ID { get; set; }
        [Required]
        public required String Amount { get; set; }

        
        [Required]
        public required String PaymentNr { get; set; }
        
        [Required]
        public required String Deadline { get; set; }

        [Required]
        [StringLength(255)]
        public required String Description { get; set; }

    }
}
