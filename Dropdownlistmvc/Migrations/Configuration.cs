namespace Dropdownlistmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dropdownlistmvc.Repository.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Dropdownlistmvc.Repository.EFDbContext";
        }

        protected override void Seed(Repository.EFDbContext context)
        {

        }
    }
}
