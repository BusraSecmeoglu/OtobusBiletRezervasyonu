namespace OtobusBiletRezervasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateNumber = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        SeatCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 12),
                        IdentificationNumber = c.String(maxLength: 12),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.PhoneNumber, unique: true)
                .Index(t => t.IdentificationNumber, unique: true);
            
            CreateTable(
                "dbo.TripPassengerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RezervedSeat = c.String(),
                        Passenger_Id = c.Int(),
                        Trip_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Passengers", t => t.Passenger_Id)
                .ForeignKey("dbo.Trips", t => t.Trip_Id)
                .Index(t => t.Passenger_Id)
                .Index(t => t.Trip_Id);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureTime = c.DateTime(nullable: false),
                        ArrivalCity_Id = c.Int(),
                        Bus_Id = c.Int(),
                        DepartureCity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.ArrivalCity_Id)
                .ForeignKey("dbo.Buses", t => t.Bus_Id)
                .ForeignKey("dbo.Cities", t => t.DepartureCity_Id)
                .Index(t => t.ArrivalCity_Id)
                .Index(t => t.Bus_Id)
                .Index(t => t.DepartureCity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripPassengerInfoes", "Trip_Id", "dbo.Trips");
            DropForeignKey("dbo.Trips", "DepartureCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Trips", "Bus_Id", "dbo.Buses");
            DropForeignKey("dbo.Trips", "ArrivalCity_Id", "dbo.Cities");
            DropForeignKey("dbo.TripPassengerInfoes", "Passenger_Id", "dbo.Passengers");
            DropIndex("dbo.Trips", new[] { "DepartureCity_Id" });
            DropIndex("dbo.Trips", new[] { "Bus_Id" });
            DropIndex("dbo.Trips", new[] { "ArrivalCity_Id" });
            DropIndex("dbo.TripPassengerInfoes", new[] { "Trip_Id" });
            DropIndex("dbo.TripPassengerInfoes", new[] { "Passenger_Id" });
            DropIndex("dbo.Passengers", new[] { "IdentificationNumber" });
            DropIndex("dbo.Passengers", new[] { "PhoneNumber" });
            DropTable("dbo.Trips");
            DropTable("dbo.TripPassengerInfoes");
            DropTable("dbo.Passengers");
            DropTable("dbo.Cities");
            DropTable("dbo.Buses");
        }
    }
}
