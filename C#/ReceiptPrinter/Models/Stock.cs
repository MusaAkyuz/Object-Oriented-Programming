using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ReceiptPrinter.Models
{
    internal class Stock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MetarialCode { get; set; }
        public string Description { get; set; }
        [Required]
        public int Unit { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
    }
}
