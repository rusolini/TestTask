namespace Dropdownlistmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Recipes", "RecipeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Recipes", "RecipeName", c => c.String());
        }
    }
}
