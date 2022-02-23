using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeliveryApp.Validations
{
    public class TypeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string type = value.ToString();
            if (type == "...")
            {
                return new ValidationResult("Enter a type of food.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
