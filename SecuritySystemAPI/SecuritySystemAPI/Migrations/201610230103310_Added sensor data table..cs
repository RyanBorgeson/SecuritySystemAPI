namespace SecuritySystemAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedsensordatatable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SensorDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Temperature = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SensorDatas");
        }
    }
}
