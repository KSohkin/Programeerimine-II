using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Payment
    {
        
        [Required]
        public required string ID { get; set; }
        [Required]
        public required string Amount { get; set; }

        
        [Required]
        public required string PaymentNr { get; set; }
        
        [Required]
        public required string Deadline { get; set; }

        [Required]
        [StringLength(255)]
        public required string Description { get; set; }

    }
}
