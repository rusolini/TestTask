using System.Collections.Generic;
using System.Linq;
using Dropdownlistmvc.Data;
using Dropdownlistmvc.Service;

namespace Dropdownlistmvc.Repository
{
    public class DishRepository : IDish
    {
        private readonly EFDbContext context = new EFDbContext();
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
                dbEntry.Id = dish.Id;
                dbEntry.FirstName = dish.FirstName;
                dbEntry.Email = dish.Email;
                dbEntry.RecipeId = dish.RecipeId;
                context.SaveChanges();
            }
        }
    }
}