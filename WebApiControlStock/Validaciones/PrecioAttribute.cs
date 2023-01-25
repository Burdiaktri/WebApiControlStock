using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStock.Validaciones
{
    public class PrecioAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            decimal newValue = Convert.ToDecimal(value);
            if(newValue < 0) {
                return ValidationResult.Success;
            }
            return new ValidationResult("El precio debe ser mayor a cero");
        }
    }
}
