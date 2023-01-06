using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using entry.Models;

namespace entry.Validators
{
    public class ValidateDateRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime resultDate;
            if (DateTime.TryParse((value).ToString(), out resultDate))
            {
                if (resultDate >= Convert.ToDateTime("01/01/1900") && resultDate <= DateTime.Now)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Date is not in given range.");
        }
        }
    }
