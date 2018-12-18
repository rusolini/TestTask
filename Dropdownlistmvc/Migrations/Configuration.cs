using WhatWeEat.Repository;

namespace WhatWeEat.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EfDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Dropdownlistmvc.Repository.EFDbContext";
        }

        protected override void Seed(Repository.EfDbContext context)
        {

        }
    }
}
