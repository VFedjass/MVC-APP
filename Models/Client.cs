using entry.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace entry.Models
{
    public enum Gender
    { Male, Female}

    public class Client
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Validators.ValidateDateRange]
        public DateTime BirthDate { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public string? Gender { get; set; }
        public List<Order>? Orders { get; set; }

        ///Functions
        public decimal OrdersAvgPrice()
        {
            return Orders?.DefaultIfEmpty()?.Average(o => o?.TotalPrice() ?? 0) ?? 0;
        }
    }
}