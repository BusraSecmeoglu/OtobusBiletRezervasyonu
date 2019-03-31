namespace OtobusBiletRezervasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BusStates", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BusStates", "Date", c => c.String(nullable: false));
        }
    }
}
