using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("VisitorStatistics")]
   public class VisitorStatistic
    {
        [Key]
        public Guid ID { set; get; }

        [Required]
        public DateTime visitedDate { set; get; }

        [MaxLength(50)]
        public String IDAddress { set; get; }
    }
}
