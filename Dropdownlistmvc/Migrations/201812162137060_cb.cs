namespace Dropdownlistmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Dishes", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Dishes", "Email");
        }
    }
}
