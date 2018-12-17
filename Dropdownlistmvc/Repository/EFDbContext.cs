using Dropdownlistmvc.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dropdownlistmvc.Repository
{
    public class EFDbContext: DbContext
    {
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
    }
}