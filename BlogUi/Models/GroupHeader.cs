using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogUi.Models
{


    public class GroupHeader
    {
       
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        [Key]
        public int grpHId { get; set; }
        public string msgId { get; set; }
        public decimal nbOfTxs { get; set; }
        public DateTime creDtTm { get; set; }
        public decimal ttlIntrBKSttlmAmt { get; set; }
        public DateTime intrBkSttlmDt { get; set; }
        public string sttlImInfSttlmMtd { get; set; }
        public string sttlInfPrtry { get; set; }
        public OrgMsgStatus _ORGMSGSTATUSID { get; set; } = new OrgMsgStatus();

        public bool GRPRTR { get; set; }

        public string GRPTYPE { get; set; }

        public int? GRPHRTRID { get; set; }

        public int? GRPHSTSID { get; set; }
        public virtual ICollection<CreditTransferInstruction> creditTransferInstruction { get; set; }


        public ICollection<GroupHeaderReturn> groupHeaderReturn { get; set; }  //= new List<GroupHeaderReturn>();


        public ICollection<GroupHeaderStatus> groupHeaderStatus { get; set; }  //= new List<GroupHeaderStatus>();


        //public ICollection<Party> party_GroupHeader = new List<Party>();


        //public ICollection<Agent> agentsGroupHader = new List<Agent>();




    }
}
