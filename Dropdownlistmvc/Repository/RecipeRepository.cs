using Dropdownlistmvc.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dropdownlistmvc.Data;

namespace Dropdownlistmvc.Repository
{
    public class RecipeRepository : IRecipe
    {
        readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Recipe> GetRecipes => context.Recipe;

        public void AddRecipes(Recipe recipe)
        {
            context.Recipe.Add(recipe);
        }
    }
}