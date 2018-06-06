using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogUi.Models
{
    public class TransactionParty
    {
        [Key]
        public int id { get; set; }
        [Column(Order = 0), Key]
        public CreditTransferInstruction creditTransferInstruction { get; set; }
        [Column(Order = 0), Key]
        public Party party { get; set; }

    }
}
