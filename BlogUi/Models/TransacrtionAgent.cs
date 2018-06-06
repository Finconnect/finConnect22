using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUi.Models
{
    public class TransacrtionAgent
    {
        [Key]
        public int id { get; set; }
        
        public ICollection<Agent> agent { get; set; }
        
        public ICollection<CreditTransferInstruction> creditTransferInstruction { get; set; }
    }
}
