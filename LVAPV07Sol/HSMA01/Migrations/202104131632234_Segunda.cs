namespace HSMA01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segunda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Students", "Phoyo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Phoyo", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            DropColumn("dbo.Students", "Photo");
        }
    }
}
