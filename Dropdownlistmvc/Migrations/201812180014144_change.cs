namespace WhatWeEat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dishes", "IX_FirstAndSecond");
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Dishes", new[] { "FirstName", "Email" }, unique: true, name: "IX_FirstAndSecond");
        }
    }
}
