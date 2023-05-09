using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTruckDatabase.Entities
{
    [Table(nameof(Truck))]
    public class Truck
    {
        public Truck()
        {
            this.Boxes = new HashSet<Box>();
        }

        [Key]
        public Guid TruckId { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Name { get; set; }
        public int Number { get; set; }
        public Guid TruckStatusId { get; set; }
        public virtual TruckStatus? TruckStatus { get; set; }
        public virtual ICollection<Box>? Boxes { get; set; }
    }
}
