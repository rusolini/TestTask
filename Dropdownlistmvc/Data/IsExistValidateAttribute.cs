using System.ComponentModel.DataAnnotations;
using System.Linq;
using WhatWeEat.Repository;

namespace WhatWeEat.Data
{
    public class IsExistRecipeValidateAttribute : ValidationAttribute
    {
        private readonly EfDbContext _context = new EfDbContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return _context.Recipe.Any(rec => rec.RecipeName == (string)value)
                ? new ValidationResult("Это блюдо уже кто-то когда-то ел")
                : null;
        }
    }
}