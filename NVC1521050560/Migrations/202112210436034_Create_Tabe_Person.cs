namespace NVC1521050560.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Tabe_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersionID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
