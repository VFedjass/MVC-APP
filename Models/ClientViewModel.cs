using System.ComponentModel.DataAnnotations;

namespace entry.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public string? Gender { get; set; }
        public int OrdersCount { get; set; }
        [DataType(DataType.Currency)]
        public decimal OrdersAvgPrice { get; set; }
    }
}
