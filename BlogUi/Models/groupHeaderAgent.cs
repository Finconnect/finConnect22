using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUi.Models
{
    public class groupHeaderAgent
    {
        [Key]
        public int id { get; set; }
        [Column(Order = 0), Key]
        public GroupHeader header { get; set; }
        [Column(Order = 1), Key]
        public Agent agent { get; set; }
    }
}
