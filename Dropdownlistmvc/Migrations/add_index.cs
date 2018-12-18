namespace WhatWeEat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_index : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 25),
                        Email = c.String(maxLength: 25),
                        RecipeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.RecipeId, cascadeDelete: true)
                .Index(t => new { t.FirstName, t.Email }, unique: true, name: "IX_FirstAndSecond")
                .Index(t => t.RecipeId);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false, identity: true),
                        RecipeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RecipeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "RecipeId", "dbo.Recipes");
            DropIndex("dbo.Dishes", new[] { "RecipeId" });
            DropIndex("dbo.Dishes", "IX_FirstAndSecond");
            DropTable("dbo.Recipes");
            DropTable("dbo.Dishes");
        }
    }
}
