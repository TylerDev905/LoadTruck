using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [Table("Truck")]
    public class Truck
    {
        [Key]
        public int TruckId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public char Status { get; set; }
    }
}
