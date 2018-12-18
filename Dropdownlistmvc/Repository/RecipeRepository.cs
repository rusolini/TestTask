using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhatWeEat.Data;
using WhatWeEat.Service;

namespace WhatWeEat.Repository
{
    public class RecipeRepository : IRecipe
    {
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<Recipe> GetRecipes => _context.Recipe;

        public void AddRecipes(Recipe recipe)
        {
            _context.Recipe.Add(recipe);
            _context.SaveChanges();
        }
    }
}