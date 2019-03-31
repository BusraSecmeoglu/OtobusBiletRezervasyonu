namespace OtobusBiletRezervasyonu
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using OtobusBiletRezervasyonu.Entities;

    public class BusModel : DbContext
    {
        public static BusModel BusModelContext = new BusModel();
            public BusModel()
            : base("name=BusModel")
        {
        }
            public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripPassengerInfo>  TripPassengerInfos{ get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<BusState>  BusStates { get; set; }

    }
}
