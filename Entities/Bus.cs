using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu.Entities
{
    public class Bus
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public override string ToString()
        {
            return PlateNumber;
        }
    }
}
