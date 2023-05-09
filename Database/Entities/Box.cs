using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [Table("Box")]
    public class Box
    {
        [Key]
        public int BoxId { get; set; }
        public string Plu { get; set; }
        public int Number { get; set; }
        public decimal Weight { get; set; }
        public char Status { get; set; }
        public int TruckId { get; set; }
        //public virtual ICollection<Truck>? Truck { get; set; }
    }
}
