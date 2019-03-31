using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public virtual Bus Bus { get; set; }
        public DateTime DepartureTime { get; set; }
      
        
        public virtual City DepartureCity { get; set; }
        public virtual City ArrivalCity { get; set; }
        public override string ToString()
        {
            return DepartureCity.Name + "->" + ArrivalCity.Name;
        }
        public string CityNames { get { return this.ToString(); } }
    }
}
