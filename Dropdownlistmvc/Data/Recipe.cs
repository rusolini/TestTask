using System.ComponentModel.DataAnnotations;

namespace WhatWeEat.Data
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Required]
        [IsExistRecipeValidate]
        public string RecipeName { get; set; }
    }
}