using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using WhatWeEat.Data;
using WhatWeEat.Service;

namespace WhatWeEat.Repository
{
    public class DishRepository : IDish
    {
        private readonly EfDbContext context = new EfDbContext();
        public IList<Dish> GetDishs => context.Dish.ToList();

        public void Delete(int? Id)
        {
            var dish = context.Dish.Find(Id);
            if (dish != null)
            {
                context.Dish.Remove(dish);
                context.SaveChanges();
            }
        }

        public Dish GetDish(int? Id)
        {
            return context.Dish.Find(Id);
        }

        public void Save(Dish dish)
        {
            if (dish.Id == 0)
            {
                context.Dish.Add(dish);
                context.SaveChanges();
            }
            else
            {
                var dbEntry = context.Dish.Find(dish.Id);
                context.Dish.Remove(dbEntry);
                context.SaveChanges();
                dbEntry.Id = dish.Id;
                dbEntry.FirstName = dish.FirstName;
                dbEntry.Email = dish.Email;
                dbEntry.RecipeId = dish.RecipeId;
                context.Dish.AddOrUpdate(dbEntry);
                context.SaveChanges();
            }
        }
    }
}