using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu.Entities
{
    public class TripPassengerInfo
    {
        public int Id { get; set; }
      
        public virtual Trip Trip { get; set; }
     
        public string RezervedSeat { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
