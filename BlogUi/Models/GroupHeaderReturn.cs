using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class GroupHeaderReturn
    {
        [Key]
        public int grpHrtId{ get; set; }
        public string msgId{ get; set; }
        public DateTime creDtTm{ get; set; }
        public decimal nbOfTxs{ get; set; }
        public bool grpRtr{ get; set; }
        public decimal ttlRtrdIntrBKSttlmAmt{ get; set; }
        public DateTime intrBkSttlmDt{ get; set; }
        public string sttlImInfSttlmMtd{ get; set; }
        public string sttlInfPrtry{ get; set; }

        public ICollection<CreditTransferInstructionReturn> creditTransferInstructionReturn = new List<CreditTransferInstructionReturn>();


        public ICollection<Party> partyGroupHeaderReturn = new List<Party>();


        public ICollection<Agent> agentGroupHeaderReturn = new List<Agent>();

        

    }
}
