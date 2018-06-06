using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUi.Models
{
    public class CraditTransferInstructionLogs
    {
        [Key]
        public int id { get; set; }
        [Column(Order = 0), Key]
        public CreditTransferInstruction creditTransferInstruction { get; set; }
        public DateTime dateInserted { get; set; }
        public int userInserted { get; set; }
        public int userModified { get; set; }
        public DateTime dateModified { get; set; }

    }
}
