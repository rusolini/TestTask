using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dropdownlistmvc.Data
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Required]
        public string RecipeName { get; set; }
    }
}