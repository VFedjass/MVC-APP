using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entry.Models
{
    public enum Status { Created = 0, Paid = 1, Delivered }
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Quantity { get; set; }
        [Required]
        [EnumDataType(typeof(Status))]
        public string? Status { get; set; }

        ///Functions
        public decimal? TotalPrice()
        {
            return Quantity * (Product?.Price ?? 0);
        }
    }
}