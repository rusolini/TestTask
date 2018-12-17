namespace Dropdownlistmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        GenderId = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        Recipes_RecipeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipes_RecipeId)
                .Index(t => t.Recipes_RecipeId);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false, identity: true),
                        RecipeName = c.String(),
                    })
                .PrimaryKey(t => t.RecipeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "Recipes_RecipeId", "dbo.Recipes");
            DropIndex("dbo.Dishes", new[] { "Recipes_RecipeId" });
            DropTable("dbo.Recipes");
            DropTable("dbo.Dishes");
        }
    }
}
