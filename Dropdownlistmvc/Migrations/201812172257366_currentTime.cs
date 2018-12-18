namespace WhatWeEat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class currentTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "CreaDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dishes", "CreaDateTime");
        }
    }
}
