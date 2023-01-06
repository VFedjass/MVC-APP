using System.ComponentModel.DataAnnotations;

namespace entry.Models
{
    public class Product
    {
        public int Id { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [StringLength(6)]
        [Required]
        public string? Code { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string? Title { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public decimal Price { get; set; }

    }
}
