using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbbyWeb.Models
{
    public class Customers
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
		[RegularExpression(@"[a-zA-Z]{2,}")]
		public string Name { get; set; }

        [Required]
        [MinLength(3)]
		[RegularExpression(@"[a-zA-Z]{2,}")]
		public string Surname { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [RegularExpression(@"[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][24680]")]
		[Column(Order = 2)]
		public string IdentityNo { get; set; }
    }
}
