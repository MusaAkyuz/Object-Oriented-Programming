using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public int Identity { get; set; }
    }
}
