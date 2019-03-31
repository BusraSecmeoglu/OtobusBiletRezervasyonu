using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu.Entities
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        [Index(IsUnique = true)]
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [Index(IsUnique =true)]
        [StringLength(12)]
        public string IdentificationNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
