using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MovieValidation : ValidationAttribute
    {
        public MovieValidation()
        {
            return;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock < 1 || movie.NumberInStock > 20)
            {
                return new ValidationResult("The field number in stock should be between 1 and 20");
            }

            return ValidationResult.Success;
           
        }
    }
}