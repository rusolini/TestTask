using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WhatWeEat.Data;
using WhatWeEat.Service;

namespace WhatWeEat.Controllers
{
    public class DishController : Controller
    {
        private readonly IDish _dishRepository;
        private readonly IRecipe _recipeRepository;

        public DishController(IDish dishRepo, IRecipe recipeRepo)
        {
            _dishRepository = dishRepo;
            _recipeRepository = recipeRepo;
        }

        public ActionResult Index()
        {
            IEnumerable<Dish> model = _dishRepository.GetDishs;
            return View(model);
        }

        public ActionResult AddDish()
        {
            Dish dish = new Dish
            {
                Id = 0,
                RecipesEnum = _recipeRepository.GetRecipes
            };
            return View("Edit", dish);
        }

        public ActionResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                if (_recipeRepository.GetRecipes.Any(rec => rec.RecipeName != recipe.RecipeName))
                {
                    _recipeRepository.AddRecipes(recipe);
                    return View("Close");
                }
            }

            return View("Confirm");
        }

        public ActionResult Confirm()
        {
            return View("Confirm");
        }

        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return HttpNotFound();
            }

            Dish dish = _dishRepository.GetDish(Id);
            dish.RecipesEnum = _recipeRepository.GetRecipes;
            return View(dish);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dish data)
        {
            
            if (ModelState.IsValid || data.Id != 0)
            {
                data.UpdateDateTime = DateTime.Now;
                _dishRepository.Save(data);
                TempData["message"] = "Save";
                return RedirectToAction("Index");
            }

            data.RecipesEnum = _recipeRepository.GetRecipes;
            return View(data);
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                HttpNotFound();
            }

            _dishRepository.Delete(Id);
            TempData["message"] = "Deleted";
            return RedirectToAction("Index");
        }
    }
}