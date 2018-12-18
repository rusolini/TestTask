using System.ComponentModel.DataAnnotations;
using System.Linq;
using WhatWeEat.Repository;

namespace WhatWeEat.Data
{
    public class IsExistValidateAttribute : ValidationAttribute
    {
        private readonly EfDbContext _context = new EfDbContext();
        private readonly string _other;

        public IsExistValidateAttribute(string other)
        {
            _other = other;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(_other);
            if (property == null)
            {
                return new ValidationResult(
                    $"Unknown property: {_other}"
                );
            }

            var otherValue = (string) property.GetValue(validationContext.ObjectInstance, null);
            return _context.Dish.Any(dish => dish.FirstName == (string) value && dish.Email == otherValue)
                ? new ValidationResult("Этот пользователь с этим Email'ом уже существует")
                : null;
        }
    }

    public class IsExistRecipeValidateAttribute : ValidationAttribute
    {
        private readonly EfDbContext _context = new EfDbContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return _context.Recipe.Any(rec => rec.RecipeName == (string)value)
                ? new ValidationResult("Этот Рецепт уже есть в системе")
                : null;
        }
    }
}