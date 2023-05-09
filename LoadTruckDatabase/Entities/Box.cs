using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTruckDatabase.Entities
{
    [Table(nameof(Box))]
    public class Box
    {
        [Key]
        public Guid BoxId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Plu { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int Number { get; set; }
        public decimal Weight { get; set; }
        public Guid? BoxStatusId { get; set; }
        public virtual BoxStatus? BoxStatus { get; set; }
        public Guid? TruckId { get; set; }
        public virtual Truck? Truck { get; set; }
    }
}
