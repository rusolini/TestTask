using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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