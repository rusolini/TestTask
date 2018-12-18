namespace WhatWeEat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "UpdateDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Dishes", "CreaDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "CreaDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Dishes", "UpdateDateTime");
        }
    }
}
