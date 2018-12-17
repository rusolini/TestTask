namespace Dropdownlistmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _as : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "Recipes_RecipeId", "dbo.Recipes");
            DropIndex("dbo.Dishes", new[] { "Recipes_RecipeId" });
            RenameColumn(table: "dbo.Dishes", name: "Recipes_RecipeId", newName: "RecipeId");
            AlterColumn("dbo.Dishes", "RecipeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dishes", "RecipeId");
            AddForeignKey("dbo.Dishes", "RecipeId", "dbo.Recipes", "RecipeId", cascadeDelete: true);
            DropColumn("dbo.Dishes", "GenderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "GenderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Dishes", "RecipeId", "dbo.Recipes");
            DropIndex("dbo.Dishes", new[] { "RecipeId" });
            AlterColumn("dbo.Dishes", "RecipeId", c => c.Int());
            RenameColumn(table: "dbo.Dishes", name: "RecipeId", newName: "Recipes_RecipeId");
            CreateIndex("dbo.Dishes", "Recipes_RecipeId");
            AddForeignKey("dbo.Dishes", "Recipes_RecipeId", "dbo.Recipes", "RecipeId");
        }
    }
}
