using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WebApiControlStock.Validaciones
{
    public class LineaProductoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            if (value.ToString().ToUpper() == "H" || value.ToString().ToUpper() == "S")
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Línea de producto solo acepta \"H\" y \"S\"!");
        }

    }
}
