using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBiletRezervasyonu.Entities
{
    public class BusState
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public override string ToString()
        {
            return $"{nameof(Id)} : {Id}, {nameof(PlateNumber)} : {PlateNumber}, {nameof(Date)} : {Date}, {nameof(TotalPrice)} : {TotalPrice}";
        }
    }
}
