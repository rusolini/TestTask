using System;
using System.Collections;
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
        private readonly IUserStatus _statusRepository;

        public DishController(IDish dishRepo, IRecipe recipeRepo, IUserStatus statusRepo)
        {
            _dishRepository = dishRepo;
            _recipeRepository = recipeRepo;
            _statusRepository = statusRepo;
        }

        public ActionResult Index(string status)
        {
            ViewBag.Text = status;
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

                var recipeName = _recipeRepository.GetRecipes.Where(recipe => recipe.RecipeId == data.RecipeId)
                    .Select(recipe => recipe.RecipeName).FirstOrDefault();

                var status = _dishRepository.GetDishs.Any(dish =>
                    dish.Email == data.Email && dish.FirstName == data.FirstName)
                    ? $"{data.FirstName}, с возвращением! Вы только что съели  " +
                      $"{recipeName}" +
                      $" Всего вы съели {recipeName}" +
                      $@" {_dishRepository.GetDishs.Count(dish => 
                          dish.RecipeId == data.RecipeId 
                          && dish.FirstName == data.FirstName 
                          && dish.Email == data.Email) + 1} " +
                      $" раз! За сегодня {recipeName} было съедено {_dishRepository.GetDishs.Count(dish => dish.RecipeId == data.RecipeId) + 1} раз"
                    : $" {data.FirstName}, мы рады приветствовать вас в нашем сообществе! Вы только что съели " +
                      $" {recipeName}" +
                      $" За сегодня {recipeName} было съедено {_dishRepository.GetDishs.Count(dish => dish.RecipeId == data.RecipeId) + 1}";


                data.UpdateDateTime = DateTime.Now;
                _dishRepository.Save(data);

                TempData["message"] = "Save";
                return RedirectToAction("Index", new {status});
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