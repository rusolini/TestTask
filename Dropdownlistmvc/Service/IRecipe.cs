using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWeEat.Data;

namespace WhatWeEat.Service
{
    public interface IRecipe
    {
        IEnumerable<Recipe> GetRecipes { get; }
        void AddRecipes(Recipe recipe);
    }
}