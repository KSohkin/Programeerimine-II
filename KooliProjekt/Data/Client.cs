using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Client
    {
        
        [Required]
        public required string ID { get; set; }
        [Required]
        [StringLength(100)]
        public required string First_name { get; set; }
        [Required]
        [StringLength(100)]
        public required string Last_name { get; set; }
        public required string Phone_number { get; set; }
        
        [Required]
        [StringLength(100)]
        public required string Email { get; set; }
    }
}
