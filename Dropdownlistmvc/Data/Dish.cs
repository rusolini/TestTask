using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dropdownlistmvc.Data
{
    public class Dish
    {
        public int  Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Email")]
        public  string Email { get; set; }
        [Required]
        [DisplayName("Recipe")]
        public int RecipeId { get; set; }
        //TO get Name Details
        public virtual Recipe Recipes { get; set; }
        //To use it with DropDownList Fill
        public virtual IEnumerable<Recipe> RecipesEnum { get; set; }
    }
}