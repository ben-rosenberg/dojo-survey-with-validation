using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Models
{

public class SurveyModel
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public string DojoLocation { get; set; }

    [Required]
    [FavoriteLanguageValidator]
    public string FavoriteLanguage { get; set; }
    
    [MaxLength(20)]
    public string Comments { get; set; }
}

/* public abstract class ValidationAttribute : Attribute
{
    protected abstract ValidationResult IsValid(SurveyModel value, ValidationContext validationContext);
} */

public class FavoriteLanguageValidatorAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((string)value == "Javascript")
        {
            return new ValidationResult("Incorrect answer, try again");
        }
        return ValidationResult.Success;
    }
}

}