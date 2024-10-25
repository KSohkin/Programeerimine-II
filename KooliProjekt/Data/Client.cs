using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Client
    {
        
        [Required]
        public String ID { get; set; }
        [Required]
        [StringLength(100)]
        public String First_name { get; set; }
        [Required]
        [StringLength(100)]
        public String Last_name { get; set; }
        public String Phone_number { get; set; }
        
        [Required]
        [StringLength(100)]
        public String Email { get; set; }
    }
}
