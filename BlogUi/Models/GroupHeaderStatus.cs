using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class GroupHeaderStatus
    {
        [Key]
        public int grpHStsId{ get; set; }
        public string msgId{ get; set; }
        public DateTime creDtTm{ get; set; }

        public ICollection<CreditTransferStatus> creditTransferStatus = new List<CreditTransferStatus>();

        
        public ICollection<Party> partyGroupHeaderStatus = new List<Party>();

        
        public ICollection<Agent> agentGroupHeaderStatus = new List<Agent>();

        

    }
}
