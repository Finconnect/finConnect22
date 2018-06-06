using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class CreditTransferInstructionReturn
    {
        [Key]
        public int cdrtxId{ get; set; }
        public string rtrId{ get; set; }
        public string orgMsgId{ get; set; }
        public string orgMsgNmId{ get; set; }
        public DateTime orgDtTm{ get; set; }
        public string orgEndToEndId{ get; set; }
        public string orgTxId{ get; set; }
        public string orgClrSysRef{ get; set; }
        public decimal rtrdIntrBKSttlAmt{ get; set; }
        public string rtrRsnInfPrtry{ get; set; }
        public decimal orgTxRefIntrBKSttlmAmt{ get; set; }
        public DateTime orgTxRefIntrBKSttlmDt{ get; set; }
        public string ogrSvcLvlPrtry{ get; set; }
        public string msgDir{ get; set; }
        
        public ICollection<Party> partyReturnTransaction = new List<Party>();

        public ICollection<Agent> agentsReturnTransaction = new List<Agent>();

       

    }
}
