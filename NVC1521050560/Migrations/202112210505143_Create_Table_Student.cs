namespace NVC1521050560.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "University", c => c.String());
            AddColumn("dbo.People", "Address", c => c.String());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Address");
            DropColumn("dbo.People", "University");
        }
    }
}
