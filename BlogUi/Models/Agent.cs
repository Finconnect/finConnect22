
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class Agent
    {
        [Key]
        public int agtCd{ get; set; }
        //[Display (Name ="fawaz")]
        
        public string agtTypeFlag{ get; set; }
        public int agtClrSystemID{ get; set; }
        public int agtClrsSystemPrtry{ get; set; }
        public string agtBIC{ get; set; }
        public string agtBrnchId{ get; set; }
        public string agtName{ get; set; }
        public string agtStreet{ get; set; }
        public string agtBldgNb{ get; set; }
        public string agtPostCode{ get; set; }
        public string agtTownName{ get; set; }
        public string agtCtryDiv{ get; set; }
        public string agtCtryName{ get; set; }
        public string agtPrtryID{ get; set; }
        public string agtPrtryIssuer{ get; set; }
        public string agtBranchFlag{ get; set; }
        public string agtBranchname{ get; set; }
        public string agtAccount{ get; set; }
        public string agtIBAN{ get; set; }
        public string agtAdrTp{ get; set; }
        public string agtDept{ get; set; }
        public string agtSubDept{ get; set; }
        public string agtCtrySubDvsn{ get; set; }
        public string agtAdrLine{ get; set; }
        public string agtOthr{ get; set; }


        //public ICollection<CreditTransferInstruction> transactionAgents = new List<CreditTransferInstruction>();

        //public ICollection<CreditTransferInstructionReturn> returnTransactionAgents = new List<CreditTransferInstructionReturn>();

        //public ICollection<GroupHeader> groupHaderAgents = new List<GroupHeader>();
        
        //public ICollection<GroupHeaderReturn> groupHeaderReturnAgent = new List<GroupHeaderReturn>();

      
        //public ICollection<GroupHeaderStatus> groupHeaderStatusAgent = new List<GroupHeaderStatus>();
        

    }

}
