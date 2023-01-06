using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace entry.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Required]
        public string? ClientName { get; set; }
        public string? ProductTitle { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Quantity { get; set; }
        [Required]
        [EnumDataType(typeof(Status))]
        public string? Status { get; set; }
        [DataType(DataType.Currency)]

        public decimal? TotalPrice { get; set; }
    }
}
