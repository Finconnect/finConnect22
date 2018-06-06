using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogUi.Models
{
    public class Party
    {
        [Key]
        public int prtyId { get; set; }
        public string prtyNm { get; set; }
        public string prtyadrTp{ get; set; }
        public string prtyDep{ get; set; }
        public string prtySubDep{ get; set; }
        public string prtyStrNm{ get; set; }
        public string prtyBldgNb{ get; set; }
        public string prtyPstCd{ get; set; }
        public string prtyTwnNm{ get; set; }
        public string prtyCtrySubDvsn{ get; set; }
        public string prtyCtryCd{ get; set; }
        public string prtyAddLine{ get; set; }
        public string prtyType{ get; set; }
        public string prtyAcctOthrId{ get; set; }
        public string prtyAcctIBAN{ get; set; }

        public CreditTransferInstruction creditTransferInstructions { get; set; }
       

      

        
        public ICollection<CreditTransferInstructionReturn> returnTransactionParty = new List<CreditTransferInstructionReturn>();

        public ICollection<GroupHeader> groupHeader_Party = new List<GroupHeader>();

      
        public ICollection<GroupHeaderReturn> groupHeaderReturnParty = new List<GroupHeaderReturn>();
        
        public ICollection<GroupHeaderStatus> groupHeaderStatusParty = new List<GroupHeaderStatus>();
        

    }
}

