using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WebApiControlStock.Validaciones
{
    public class LineaProductoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string newValue = Convert.ToString(value);

            if(newValue == "S" || newValue == "H") {
                return ValidationResult.Success;
            }
            return new ValidationResult("Linea de producto solo acepta S o H");
        }
    }
}
