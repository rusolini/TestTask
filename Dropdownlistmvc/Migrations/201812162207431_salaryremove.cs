namespace Dropdownlistmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class salaryremove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Dishes", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "Salary", c => c.Int(nullable: false));
        }
    }
}
