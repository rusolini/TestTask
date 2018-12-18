using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace WhatWeEat.Data
{
    public class Dish
    {
        public int Id { get; set; }

        [DisplayName("Update Time")]
        public DateTime UpdateDateTime { get; set; }

        [Required]
        [DisplayName("First Name")]
        [Index("IX_FirstAndSecond", 1, IsUnique = true)]
        [MaxLength(25)]
        [IsExistValidateAttribute("Email")]
        public string FirstName { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        [Index("IX_FirstAndSecond", 2, IsUnique = true)]
        [MaxLength(25)]
        public string Email { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Выберите рецепт")]
        [DisplayName("Recipe")]
        public int RecipeId { get; set; }

        public virtual Recipe Recipes { get; set; }

        //To use it with DropDownList Fill
        public virtual IEnumerable<Recipe> RecipesEnum { get; set; }
    }
}