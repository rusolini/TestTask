using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WhatWeEat.Data;
using WhatWeEat.Data;

namespace WhatWeEat.Repository
{
    public class EfDbContext: DbContext
    {
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
    }
}