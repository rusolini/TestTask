namespace WhatWeEat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_required : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dishes", "IX_FirstAndSecond");
            AlterColumn("dbo.Dishes", "FirstName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Dishes", "Email", c => c.String(nullable: false, maxLength: 25));
            CreateIndex("dbo.Dishes", new[] { "FirstName", "Email" }, unique: true, name: "IX_FirstAndSecond");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dishes", "IX_FirstAndSecond");
            AlterColumn("dbo.Dishes", "Email", c => c.String(maxLength: 25));
            AlterColumn("dbo.Dishes", "FirstName", c => c.String(maxLength: 25));
            CreateIndex("dbo.Dishes", new[] { "FirstName", "Email" }, unique: true, name: "IX_FirstAndSecond");
        }
    }
}
