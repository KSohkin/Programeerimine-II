using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Client
    {
        
        [Required]
        public required String ID { get; set; }
        [Required]
        [StringLength(100)]
        public required String First_name { get; set; }
        [Required]
        [StringLength(100)]
        public required String Last_name { get; set; }
        public required String Phone_number { get; set; }
        
        [Required]
        [StringLength(100)]
        public required String Email { get; set; }
    }
}
