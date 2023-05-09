using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTruckDatabase.Entities
{
    [Table(nameof(TruckStatus))]
    public class TruckStatus
    {
        [Key]
        public Guid TruckStatusId { get; set; }
        [Column(TypeName = "char(1)")]
        public char Value { get; set; }
        public string Text { get; set; }
    }
}
