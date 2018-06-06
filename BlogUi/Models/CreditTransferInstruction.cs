using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogUi.Models
{   
    public class CreditTransferInstruction
    {
        
        public string pmtIdEndToEndId { get; set; }
        public string pmtIdTxId { get; set; }
        public decimal intrBkSttlmAm { get; set; }
        public string chrgBr { get; set; }
        public string instInf { get; set; }
        [Key]
        public int cdTxId { get; set; }
        public string msgDir { get; set; }
       
        //[ForeignKey("grpHId")]
        //public virtual GroupHeader GRPHID { get; set; }

        ////public int? grpHId { get; set; }
        public GroupHeader GRPHID { get; set; }

        public int? ccyId { get; set; }
        [ForeignKey("ccyId")]
        public virtual Currency CCYID { get; set; }
        public ICollection<CreditTransferInstructionReturn> creditTransferInstructionReturn { get; set; }
        public ICollection<Party> parties { get; set; } = new List<Party>();
        public ICollection<Agent> agents { get; set; } = new List<Agent>();

       // public ICollection<TransacrtionAgent> tranAgent { get; set; }


    }
}
